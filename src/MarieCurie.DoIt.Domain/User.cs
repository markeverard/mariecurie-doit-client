using System;

namespace MarieCurie.DoIt.Domain
{
    public class User : TrackModified
    {
        public Guid Id { get; set; }
        public bool Activated { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
