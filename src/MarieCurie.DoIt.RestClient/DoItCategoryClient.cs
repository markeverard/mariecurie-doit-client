using System;
using System.Collections.Generic;
using MarieCurie.DoIt.Domain;
using MarieCurie.DoIt.Domain.Dictionaries;
using MarieCurie.DoIt.RestClient.Request;
using MarieCurie.DoIt.RestClient.Response;
using RestSharp;

namespace MarieCurie.DoIt.RestClient
{
    public class DoItCategoryClient : DoItClient
    {
        public DoItCategoryClient()
        {
        }

        public DoItCategoryClient(string endPoint)
            : base(endPoint)
        {
        }

        public Category Get(CategoryGetRequest categoryRequest)
        {
            var resource = "categories/" + categoryRequest.Uuid.ToString().ToLower();
            var request = new RestRequest(resource, Method.GET);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");
           
            //IRestResponse<OpportunityResponse> response = Client.Execute<OpportunityResponse>(request);
            //return response.Data.Data.;

            //maybe hardcode these see InterestsDictionaries
            throw new NotImplementedException();
        }
    }
}
