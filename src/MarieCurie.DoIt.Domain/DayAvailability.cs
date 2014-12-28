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
           var availability = new List<bool> { false, false, false };
           Monday = availability;
           Tuesday = availability;
           Wednesday = availability;
           Thursday = availability;
           Friday = availability;
           Saturday = availability;
           Sunday = availability;
       }
       
       public void SetDayAvailability(DayOfWeek day, bool morning, bool afternoon, bool evening)
       {
           var availability = new List<bool> {morning, afternoon, evening};

           switch (day)
           {
                case DayOfWeek.Monday:
                   Monday = availability;
                   break;
                case DayOfWeek.Tuesday:
                   Tuesday = availability;
                   break;
                case DayOfWeek.Wednesday:
                   Wednesday = availability;
                   break;
                case DayOfWeek.Thursday:
                   Thursday = availability;
                   break;
                case DayOfWeek.Friday:
                   Friday = availability;
                   break;
                case DayOfWeek.Saturday:
                   Saturday = availability;
                   break;
                default:
                   Sunday = availability;
                   break;
           }
       }
    }
}
