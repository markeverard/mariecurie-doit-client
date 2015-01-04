using System;

namespace MarieCurie.DoIt.RestClient.Request
{
    public class LocalAuthoritySearchRequest : LocationSearchRequestBase
    {
        public Guid Id { get; set; } 
        public string Slug { get; set; } 
    }
}