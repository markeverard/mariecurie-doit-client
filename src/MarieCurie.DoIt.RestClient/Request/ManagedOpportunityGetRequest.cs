using System;

namespace MarieCurie.DoIt.RestClient.Request
{
    public class ManagedOpportunityGetRequest : PaginatedRequest
    {
        public string Title { get; set; }
        public Guid RecruiterId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool GetDraftsOnly { get; set; }
    }
}