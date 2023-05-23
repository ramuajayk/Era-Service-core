using Era_service_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Era_service_core.Helpers
{
    public static class DistanceOperation
    {
        public static double CalculateDistance(Geolocation location1, Geolocation location2)
        {
            double earthRadius = 6371; // Earth's radius in kilometers

            double lat1 = Math.PI / 180 * location1.GetLatitude();
            double lon1 = Math.PI / 180 * location1.GetLongitude();

            double lat2 = Math.PI / 180 * location2.GetLatitude();
            double lon2 = Math.PI / 180 * location2.GetLongitude();

            double latDiff = lat2 - lat1;
            double lonDiff = lon2 - lon1;

            double a = Math.Sin(latDiff / 2) * Math.Sin(latDiff / 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Sin(lonDiff / 2) * Math.Sin(lonDiff / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return earthRadius * c;
        }
    }
}
