using System;
using System.Collections.Generic;

namespace MarieCurie.DoIt.Domain
{
    public class Opportunity: TrackModified
    {
         public Guid Id { get; set; }
         public string Status { get; set; }
         
         public string Title { get; set; }
         public string Blurb { get; set; }
         public string Description { get; set; }
         public string Practical { get; set; }
         
         public string Address1 { get; set; } 
         public string Address2 { get; set; }
         public string City { get; set; }
         public string County { get; set; } 
         public string Phone { get; set; }
         public string Postcode { get; set; }

         public double Lat { get; set; }
         public double Lng { get; set; }
         public double Miles { get; set; }

         public object location_id { get; set; }
         public object location_name { get; set; }
         public object location_type { get; set; }
         
         public Guid Owner_recruiter_id { get; set; }
         public Guid For_recruiter_id { get; set; }
         public Guid Apply_recruiter_id { get; set; }

         public List<Activity> Activities { get; set; }
         public List<Interest> Interests { get; set; }
         public List<Requirement> requirements { get; set; }
         public List<Skill> Skills_gained { get; set; }
         public List<Skill> Skills_required { get; set; }
         public List<Suitability> suitibilities { get; set; }

         public Availability Availability { get; set; }

         public int Places_available { get; set; }
         public bool Working_from_home { get; set; }

         public DateTime Advertise_Start_Date { get; set; } 
         public DateTime Advertise_End_Date { get; set; }

         public DateTime Specific_End_Date { get; set; }
         public DateTime Specific_Start_Date { get; set; }
        
         public bool Draft { get; set; }
         public bool Expired { get; set; }
         
         public List<Image> Photo { get; set; }
         
         public string Rating { get; set; }
         public int Rating_count { get; set; }
        
         public bool Is_new { get; set; }
         public bool Is_user_saved { get; set; }
    }
}
