using System;
using MarieCurie.DoIt.Domain;

namespace MarieCurie.DoIt.RestClient.Request
{
    public class OpportunityUpdateRequest : OpportunityCreateRequest
    {
        public OpportunityUpdateRequest(Opportunity opportunity) : base(opportunity)
        {
            Uuid = opportunity.Id;
        }

        public Guid Uuid { get; set; }
    }
}