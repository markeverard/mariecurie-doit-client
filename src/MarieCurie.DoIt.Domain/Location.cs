using System;
using System.Collections.Generic;

namespace MarieCurie.DoIt.Domain
{
    public class Location
    {
        public Guid Id { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        
        public string Name { get; set; }
       
        public List<LocalAuthority> Local_Authority { get; set; }        
    }
}