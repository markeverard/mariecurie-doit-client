using System;
using System.Collections.Generic;
using System.Linq;
using MarieCurie.DoIt.Domain;
using MarieCurie.DoIt.RestClient.Request;
using MarieCurie.DoIt.RestClient.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace MarieCurie.DoIt.RestClient
{
    public class DoItOpportunityClient : DoItClient
    {
        public DoItOpportunityClient()
        {
        }

        public DoItOpportunityClient(string endPoint) : base(endPoint)
        {
        }

        /// <summary>
        /// Gets the specified published opportunity.
        /// </summary>
        /// <param name="opportunityRequest">The opportunity get request.</param>
        /// <returns></returns>
        public Opportunity Get(OpportunityGetRequest opportunityRequest)
        {
            var request = CreateRestRequestForOpportunity(opportunityRequest);

            IRestResponse<OpportunityResponse> response = Client.Execute<OpportunityResponse>(request);
            return response.Data.Data.Opportunity;
        }

        /// <summary>
        /// Gets a draft or unpublished opportunitiy that is managed by the suthenticated user
        /// </summary>
        /// <param name="opportunityRequest">The opportunity get request with authentication pararmeters.</param>
        /// <returns></returns>
        public Opportunity GetManaged(AuthenticatedRequest<OpportunityGetRequest> opportunityRequest)
        {
            var request = CreateRestRequestForOpportunity(opportunityRequest.Request);
            AuthenticateRequest(ref request, opportunityRequest.Email, opportunityRequest.Password);

            IRestResponse<OpportunityResponse> response = Client.Execute<OpportunityResponse>(request);
            return response.Data.Data.Opportunity;
        }

        /// <summary>
        /// Creates the rest request for opportunity get.
        /// </summary>
        /// <param name="opportunityRequest">The opportunity get request.</param>
        /// <returns></returns>
        private static RestRequest CreateRestRequestForOpportunity(OpportunityGetRequest opportunityRequest)
        {
            var resource = "opportunities/" + opportunityRequest.Uuid.ToString().ToLower();

            var request = new RestRequest(resource, Method.GET);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");
            return request;
        }

        /// <summary>
        /// Searches the public opportunities via the specified parameters.
        /// </summary>
        /// <param name="opportunityRequest">The opportunity request.</param>
        /// <returns></returns>
        public ItemsResponse<Opportunity> Search(OpportunitySearchRequest opportunityRequest)
        {
            var request = CreateRestRequestForOpportunitySearch(opportunityRequest);

            IRestResponse<ItemsResponse<Opportunity>> response = Client.Execute<ItemsResponse<Opportunity>>(request);
            
            return response.Data;
        }

        /// <summary>
        /// Creates the rest request for opportunity search.
        /// </summary>
        /// <param name="opportunityRequest">The opportunity search request.</param>
        /// <returns></returns>
        private static RestRequest CreateRestRequestForOpportunitySearch(OpportunitySearchRequest opportunityRequest)
        {
            var request = new RestRequest("opportunities", Method.GET);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");

            if (opportunityRequest.Interests.Any())
                request.AddParameter("interests", string.Join(",", opportunityRequest.Interests.Select(x => x)));

            if (opportunityRequest.Activities.Any())
                request.AddParameter("activities", string.Join(",", opportunityRequest.Activities.Select(x => x)));

            if (opportunityRequest.Skills.Any())
                request.AddParameter("skills", string.Join(",", opportunityRequest.Skills.Select(x => x)));

            if (opportunityRequest.RecruiterId != Guid.Empty)
                request.AddParameter("recruiter_id", opportunityRequest.RecruiterId);

            if (opportunityRequest.ForRecruiterId != Guid.Empty)
                request.AddParameter("for_recruiter_id", opportunityRequest.ForRecruiterId);

            if (opportunityRequest.OwnerRecruiterId != Guid.Empty)
                request.AddParameter("owner_recruiter_id", opportunityRequest.OwnerRecruiterId);

            if (opportunityRequest.ApplyRecruiterId != Guid.Empty)
                request.AddParameter("apply_recruiter_id", opportunityRequest.ApplyRecruiterId);

            if (!string.IsNullOrWhiteSpace(opportunityRequest.Location_id))
                request.AddParameter("location_id", opportunityRequest.Location_id);

            if (!string.IsNullOrWhiteSpace(opportunityRequest.Lat))
                request.AddParameter("lat", opportunityRequest.Lat);

            if (!string.IsNullOrWhiteSpace(opportunityRequest.Lng))
                request.AddParameter("lng", opportunityRequest.Lng);

            if (!string.IsNullOrWhiteSpace(opportunityRequest.Miles))
                request.AddParameter("miles", opportunityRequest.Miles);

            if (opportunityRequest.Page > 1)
                request.AddParameter("page", opportunityRequest.Page);

            return request;
        }

        /// <summary>
        /// Creates an opportunity.
        /// </summary>
        /// <param name="opportunityRequest">The opportunity create request.</param>
        /// <returns></returns>
        public Opportunity Create(AuthenticatedRequest<OpportunityCreateRequest> opportunityRequest)
        {
            var request = new RestRequest("opportunities", Method.POST);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");
           
            AuthenticateRequest(ref request, opportunityRequest.Email, opportunityRequest.Password);
            
            var json = JsonConvert.SerializeObject(opportunityRequest.Request, Formatting.Indented, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });

            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
           
            IRestResponse<OpportunityResponse> response = Client.Execute<OpportunityResponse>(request);
            return response.Data.Data.Opportunity;
        }

        /// <summary>
        /// Deletes the specified opportunity.
        /// </summary>
        /// <param name="opportunityRequest">The opportunity delete request.</param>
        /// <returns></returns>
        public bool Delete(AuthenticatedRequest<OpportunityDeleteRequest> opportunityRequest)
        {
            var resource = "opportunities/" + opportunityRequest.Request.Uuid.ToString().ToLower();

            var request = new RestRequest(resource, Method.DELETE);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");

            AuthenticateRequest(ref request, opportunityRequest.Email, opportunityRequest.Password);

            IRestResponse<DoItResponse> response = Client.Execute<DoItResponse>(request);

            return response.ResponseStatus == ResponseStatus.Completed;
        }

        /// <summary>
        /// Updates the specified opportunity.
        /// </summary>
        /// <param name="opportunityRequest">The opportunity update request.</param>
        /// <returns></returns>
        public Opportunity Update(AuthenticatedRequest<OpportunityUpdateRequest> opportunityRequest)
        {
            var resource = "opportunities/" + opportunityRequest.Request.Uuid.ToString().ToLower();

            var request = new RestRequest(resource, Method.PUT);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");

            AuthenticateRequest(ref request, opportunityRequest.Email, opportunityRequest.Password);

            var json = JsonConvert.SerializeObject(opportunityRequest.Request, Formatting.Indented, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
           
            IRestResponse<OpportunityResponse> response = Client.Execute<OpportunityResponse>(request);
            return response.Data.Data.Opportunity;
        }


    }
}
