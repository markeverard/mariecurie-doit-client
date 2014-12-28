using System;
using MarieCurie.DoIt.Domain;
using MarieCurie.DoIt.RestClient.Request;
using MarieCurie.DoIt.RestClient.Response;
using RestSharp;

namespace MarieCurie.DoIt.RestClient
{
    public class DoItUserClient : DoItClient
    {
        public DoItUserClient()
        {
        }

        public DoItUserClient(string endPoint)
            : base(endPoint)
        {
        }

        /// <summary>
        /// Returns opportunities managed by the authenticated user
        /// </summary>
        /// <param name="managedRequest">The managed opportunity request with authenication parameters.</param>
        /// <returns></returns>
        public ItemsResponse<Opportunity> ManagedOpportunities(AuthenticatedRequest<ManagedOpportunityGetRequest> managedRequest)
        {
            var request = new RestRequest("users/opportunities/manage", Method.GET);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");

            if (!string.IsNullOrEmpty(managedRequest.Request.Title))
                request.AddParameter("title", managedRequest.Request.Title);

            if (managedRequest.Request.RecruiterId != Guid.Empty)
                request.AddParameter("recruiter_id", managedRequest.Request.RecruiterId);

            if (managedRequest.Request.StartDate > DateTime.MinValue)
                request.AddParameter("start_date", managedRequest.Request.StartDate);

            if (managedRequest.Request.EndDate > DateTime.MinValue)
                request.AddParameter("end_date", managedRequest.Request.EndDate);

            if (managedRequest.Request.GetDraftsOnly)
                request.AddParameter("draft", 1);

            if (managedRequest.Request.Page > 1)
                request.AddParameter("page", managedRequest.Request.Page);

            AuthenticateRequest(ref request, managedRequest.Email, managedRequest.Password);

            IRestResponse<ItemsResponse<Opportunity>> response = Client.Execute<ItemsResponse<Opportunity>>(request);

            return response.Data;
        }
    }
}
