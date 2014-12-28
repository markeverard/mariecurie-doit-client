using MarieCurie.DoIt.Domain;
using MarieCurie.DoIt.RestClient.Request;
using MarieCurie.DoIt.RestClient.Response;
using RestSharp;

namespace MarieCurie.DoIt.RestClient
{
    public class DoItOrganisationClient : DoItClient
    {
        public DoItOrganisationClient()
        {
        }

        public DoItOrganisationClient(string endPoint) : base(endPoint)
        {
        }

        public Organisation Get(OrganisationGetRequest orgRequest)
        {
            var resource = "orgs/" + orgRequest.Uuid.ToString().ToLower();
           
            var request = new RestRequest(resource, Method.GET);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");
            
            IRestResponse<OrganisationResponse> response = Client.Execute<OrganisationResponse>(request);
            return response.Data.Data.Recruiter;
        }
    }
}
