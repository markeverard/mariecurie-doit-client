using System;
using System.Collections.Generic;

namespace MarieCurie.DoIt.RestClient.Request
{
    public class OpportunitySearchRequest : PaginatedRequest
    {
        public string Location { get; set; }
        public string Miles { get; set; }
        public IEnumerable<Guid> Interests { get; set; }
        public IEnumerable<Guid> Activities { get; set; }
        public IEnumerable<Guid> Skills { get; set; }
        //filter opportunities owned by this recruiter.
        public Guid OwnerRecruiterId { get; set; }
        //filter opportunities that are for this recruiter
        public Guid ForRecruiterId { get; set; }
        //filter opportunities that are applied for at this recruiter.
        public Guid ApplyRecruiterId { get; set; }
        //filter all opportunities both for this recruiter and owned by this recruiter.
        public Guid RecruiterId { get; set; }
    }
}