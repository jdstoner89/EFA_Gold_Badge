using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFour_Repository
{
    public class Outings
    {
        public string EventType { get; set; }
        public int Attendance { get; set; }
        public string EventDate { get; set; }
        public double PersonCost { get; set; }
        public double EventCost { get; set; }
        public Outings () { }
        public Outings(string eventType, int attendance, string eventDate, double personCost, double eventCost)
        {
            EventType = eventType;
            Attendance = attendance;
            EventDate = eventDate;
            PersonCost = personCost;
            EventCost = eventCost;
        }
    }
}
