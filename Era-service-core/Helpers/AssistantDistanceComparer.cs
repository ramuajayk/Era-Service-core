using Era_service_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Era_service_core.Helpers
{
    public class AssistantDistanceComparer : IComparer<Assistant>
    {
        readonly Geolocation location;      

        public AssistantDistanceComparer(Geolocation geolocation)
        {
            location = geolocation;
        }

        public int Compare(Assistant? a1, Assistant? a2)
        {
            if (a1 != null && a2 != null)
            {
                double distance1 = DistanceOperation.CalculateDistance(location, a1.GetLocation());
                double distance2 = DistanceOperation.CalculateDistance(location, a2.GetLocation());
                return distance1.CompareTo(distance2);
            }
            return 0;
        }

       
    }

}
