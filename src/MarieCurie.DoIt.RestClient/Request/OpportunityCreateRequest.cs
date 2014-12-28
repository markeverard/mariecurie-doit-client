using System;
using System.Collections.Generic;
using MarieCurie.DoIt.Domain;

namespace MarieCurie.DoIt.RestClient.Request
{
    public class OpportunityCreateRequest
    {
        public OpportunityCreateRequest()
        {
            Activities = new List<Guid>();
            Availability = new Availability();
            Interests = new List<Guid>();
            Requirements = new List<Guid>();
            Skills_gained = new List<Guid>();
            Skills_required = new List<Guid>();
            Suitibilities = new List<Guid>();
        }

        public List<Guid> Activities { get; set; }
        public string Address { get; set; } 
        public Availability Availability { get; set; }
        public string Blurb { get; set; }
        public string Description { get; set; }
        public List<Guid> Interests { get; set; }
        public int Places_available { get; set; } 
        public List<Guid> Requirements { get; set; }
        public List<Guid> Skills_gained { get; set; }
        public List<Guid> Skills_required { get; set; }
        public List<Guid> Suitibilities { get; set; }
        public string Title { get; set; }

        public Guid Owner_recruiter_id { get; set; }
        public Guid For_recruiter_id { get; set; }
        public Guid Apply_recruiter_id { get; set; }
    }
}
