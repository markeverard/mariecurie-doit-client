using System;
using System.Collections.Generic;
using System.Linq;
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

        public OpportunityCreateRequest(Opportunity opportunity)
        {
            Activities = opportunity.Activities != null ? opportunity.Activities.Select(a => a.Id).ToList() : null;
            Availability = opportunity.Availability;
            Blurb = opportunity.Blurb;
            Description = opportunity.Description;
            Interests = opportunity.Interests != null ? opportunity.Interests.Select(a => a.Id).ToList() : null;
            Places_available = opportunity.Places_available;
            Practical = opportunity.Practical;
            Requirements = opportunity.Requirements != null ? opportunity.Requirements.Select(a => a.Id).ToList() : null;
            Skills_gained = opportunity.Skills_gained != null ? opportunity.Skills_gained.Select(a => a.Id).ToList() : null;
            Skills_required = opportunity.Skills_required != null ? opportunity.Skills_required.Select(a => a.Id).ToList() : null;
            Suitibilities = opportunity.Suitibilities != null ? opportunity.Suitibilities.Select(a => a.Id).ToList() : null;
            Title = opportunity.Title;

            Owner_recruiter_id = opportunity.Owner_recruiter_id;
            For_recruiter_id = opportunity.For_recruiter_id;
            Apply_recruiter_id = opportunity.Apply_recruiter_id;
           
            Address1 = opportunity.Address_1;
            Address2 = opportunity.Address_2;
            City = opportunity.City;
            County = opportunity.County;
            Phone = opportunity.Phone;
            Postcode = opportunity.Postcode;

            Location_id = opportunity.Location_id.HasValue ? opportunity.Location_id : null;
            Location_type = CalculateFromLocationElements(opportunity);
         
            Working_from_home = opportunity.Working_from_home;

            Advertise_start_date = opportunity.Advertise_start_date;
            Advertise_end_date = opportunity.Advertise_end_date;
            Specific_start_date = opportunity.Specific_start_date;
            Specific_end_date = opportunity.Specific_end_date;

            Draft = opportunity.Draft;
        }

        private string CalculateFromLocationElements(Opportunity opportunity)
        {
            if (opportunity.Working_from_home)
                return null;

            if (opportunity.Location_id.HasValue)
                return LocationType.RL.ToString();

            if (!string.IsNullOrEmpty(opportunity.Postcode))
                return LocationType.SL.ToString();

            return null;
        }


        public List<Guid> Activities { get; set; }
        public Availability Availability { get; set; }
        public string Blurb { get; set; }
        public string Description { get; set; }
        public List<Guid> Interests { get; set; }
        public int Places_available { get; set; }
        public string Practical { get; set; }
        public List<Guid> Requirements { get; set; }
        public List<Guid> Skills_gained { get; set; }
        public List<Guid> Skills_required { get; set; }
        public List<Guid> Suitibilities { get; set; }
        public string Title { get; set; }

        public Guid Owner_recruiter_id { get; set; }
        public Guid For_recruiter_id { get; set; }
        public Guid Apply_recruiter_id { get; set; }

        
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Phone { get; set; }
        public string Postcode { get; set; }

        public Guid? Location_id { get; set; }
        public string Location_type { get; internal set; }

        public bool Working_from_home { get; set; }

        public DateTime Advertise_start_date { get; set; }
        public DateTime Advertise_end_date { get; set; }

        public DateTime Specific_end_date { get; set; }
        public DateTime Specific_start_date { get; set; }

        public bool Draft { get; set; }
    }
}
