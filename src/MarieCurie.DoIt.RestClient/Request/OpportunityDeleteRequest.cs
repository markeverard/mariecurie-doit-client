using System;

namespace MarieCurie.DoIt.RestClient.Request
{
    public class OpportunityUpdateRequest : OpportunityCreateRequest
    {
        public Guid Uuid { get; set; }
    }
}