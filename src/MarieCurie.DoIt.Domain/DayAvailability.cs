using System;
using System.Collections.Generic;

namespace MarieCurie.DoIt.Domain
{
   public class Availability
   {
       public Availability()
       {
           SetDefaultValues();
       }

        public List<bool> Friday { get; set; }
        public List<bool> Monday { get; set; }
        public List<bool> Saturday { get; set; }
        public List<bool> Sunday { get; set; }
        public List<bool> Thursday { get; set; }
        public List<bool> Tuesday { get; set; }
        public List<bool> Wednesday { get; set; }

        protected void SetDefaultValues()
        {
           Monday = new List<bool> { false, false, false }; ;
           Tuesday = new List<bool> { false, false, false }; ;
           Wednesday = new List<bool> { false, false, false }; ;
           Thursday = new List<bool> { false, false, false }; ;
           Friday = new List<bool> { false, false, false }; ;
           Saturday = new List<bool> { false, false, false }; ;
           Sunday = new List<bool> { false, false, false }; ;
       }
       
      
    }
}
