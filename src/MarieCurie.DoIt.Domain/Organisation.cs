namespace MarieCurie.DoIt.Domain
{
    public class Organisation : TrackModified
    {
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public object Banner { get; set; }
        public string Blurb { get; set; }
        public bool Charity { get; set; }
        public string Charity_no { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Id { get; set; }
        public string Instagram { get; set; }
        public string Rating { get; set; }
        public string Rating_count { get; set; }
        public object Logo { get; set; }
        public string Name { get; set; }
        public object Phone { get; set; }
        public string Postcode { get; set; }
        public string Slug { get; set; }
        public string Twitter { get; set; }
        public bool Volunteer_center { get; set; }
        public string Website { get; set; }
        public Permissions Permissions { get; set; }
    }


    public class OpportunityPermissions
    {
        public bool Create { get; set; }
        public bool Delete { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
    }

    public class RecruiterPermissions
    {
        public bool Add_members { get; set; }
        public bool Delete_members { get; set; }
        public bool Update { get; set; }
        public bool Update_members { get; set; }
    }

    public class Permissions
    {
        public OpportunityPermissions Opportunity_permissions { get; set; }
        public RecruiterPermissions Recruiter_permissions { get; set; }
    }
}