using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFour_Repository
{
    public class OutingsRepository
    {
        private List<Outings> _listOfOutings = new List<Outings>();
        //create
        public void AddOutingToList(Outings outing)
        {
            _listOfOutings.Add(outing);
        }
        //read
        public List<Outings> GetOutingsList()
        {
            return _listOfOutings;
        }
        
        //helper methods
        public Outings GetOutingByEventType(string eventType)
        {
            foreach(Outings outing in _listOfOutings)
            {
                if(outing.EventType.ToLower() == eventType.ToLower())
                {
                    return outing;
                }
            }
            return null;
        }
    }
}
