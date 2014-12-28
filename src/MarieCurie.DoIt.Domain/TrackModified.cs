using System;

namespace MarieCurie.DoIt.Domain
{
    public abstract class TrackModified
    {
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
