
using System;
using System.Linq;
using MarieCurie.DoIt.Domain;
using MarieCurie.DoIt.RestClient.Request;
using MarieCurie.DoIt.RestClient.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace MarieCurie.DoIt.RestClient
{
    public abstract class DoItClient
    {
        private const string EndPoint = "http://private-10abc-doit.apiary-mock.com/v1/";

        protected RestSharp.RestClient Client;

        protected DoItClient()
        {
            Token = new AuthenticationToken();
            Client = new RestSharp.RestClient(EndPoint);
        }

        protected DoItClient(string endPoint)
        {
            Token = new AuthenticationToken();
            Client = new RestSharp.RestClient(endPoint);
        }

        protected AuthenticationToken Token { get; set; }

        protected void AuthenticateRequest(ref RestRequest restRequest, string email, string password)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Cannot authenticate as Email is null or empty");

            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Cannot authenticate as Password is null or empty");

            if (!Token.IsExpired)
            {
                restRequest.AddHeader(AuthenticationToken.HeaderName, Token.Value);
                return;
            }

            var authenticationRequest = new AuthenticationRequest {Email = email, Password = password};

            const string resource = "users/login";
            var request = new RestRequest(resource, Method.POST);
            request.AddHeader("Accept", "application/json, text/json, text/x-json, text/javascript");
           
            var json = JsonConvert.SerializeObject(authenticationRequest, Formatting.Indented, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });

            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            IRestResponse<UserResponse> response = Client.Execute<UserResponse>(request);
            var tokenHeader = response.Headers.Single(c => c.Name == "X-Auth-Token");
            Token = new AuthenticationToken { Value = tokenHeader.Value.ToString(), Expiry = DateTime.Now.AddHours(1)};


            restRequest.AddHeader(AuthenticationToken.HeaderName, Token.Value);
        }

        protected void UpdateTokenExpiry(DateTime newExpiryDate)
        {
            if (Token == null)
                return;

            Token.Expiry = newExpiryDate;
        }
    }
}
