using MarieCurie.DoIt.Domain;
using MarieCurie.DoIt.RestClient.Request;
using MarieCurie.DoIt.RestClient.Response;
using RestSharp;

namespace MarieCurie.DoIt.RestClient
{
    public class DoItLocationClient : DoItClient
    {
        public DoItLocationClient()
        {
        }

        public DoItLocationClient(string endPoint): base(endPoint)
        {
        }

        /// <summary>
        /// Searches locations for those matching the specfied location seearch parameters.
        /// </summary>
        /// <param name="searchRequest">The search request.</param>
        /// <returns></returns>
        public ItemsResponse<Location> Search(LocationSearchRequest searchRequest)
        {
            const string resource = "location/uk/locations";
           
            var request = new RestRequest(resource, Method.GET);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");

            if (searchRequest.Page > 1)
                request.AddHeader("page", searchRequest.Page.ToString());

            if (searchRequest.Limit > 0)
                request.AddHeader("limit", searchRequest.Limit.ToString());

            if (!string.IsNullOrEmpty(searchRequest.Name))
                request.AddHeader("name", searchRequest.Name);

            IRestResponse<ItemsResponse<Location>> response = Client.Execute<ItemsResponse<Location>>(request);
            return response.Data;
        }

        /// <summary>
        /// Searches local authorities for those matching the specfied location seearch parameters.
        /// </summary>
        /// <param name="searchRequest">The search request.</param>
        /// <returns></returns>
        public ItemsResponse<LocalAuthority> SearchLocalAuthority(LocationSearchRequest searchRequest)
        {
            const string resource = "location/uk/la";

            var request = new RestRequest(resource, Method.GET);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");

            if (searchRequest.Page > 1)
                request.AddHeader("page", searchRequest.Page.ToString());

            if (searchRequest.Limit > 0)
                request.AddHeader("limit", searchRequest.Limit.ToString());

            if (!string.IsNullOrEmpty(searchRequest.Name))
                request.AddHeader("name", searchRequest.Name);

            IRestResponse<ItemsResponse<LocalAuthority>> response = Client.Execute<ItemsResponse<LocalAuthority>>(request);
            return response.Data;
        }

        /// <summary>
        /// Returns the a list of opportunities for the specified local authority - (uses slug over local authority Id)
        /// </summary>
        /// <param name="searchRequest">The search request.</param>
        /// <returns></returns>
        public ItemsResponse<Opportunity> OpportunitiesForLocalAuthority(LocalAuthoritySearchRequest searchRequest)
        {
            var localAuthorityIdentifier = string.IsNullOrEmpty(searchRequest.Slug)
                ? searchRequest.Id.ToString()
                : searchRequest.Slug;
            
            var resource = "location/uk/la/" + localAuthorityIdentifier + "/opportunities";

            var request = new RestRequest(resource, Method.GET);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");

            if (searchRequest.Page > 1)
                request.AddHeader("page", searchRequest.Page.ToString());

            if (searchRequest.Limit > 0)
                request.AddHeader("limit", searchRequest.Limit.ToString());

         
            IRestResponse<ItemsResponse<Opportunity>> response = Client.Execute<ItemsResponse<Opportunity>>(request);
            return response.Data;
        }
    }
}
