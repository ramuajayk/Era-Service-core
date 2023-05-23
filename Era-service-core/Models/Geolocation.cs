using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Era_service_core.Models
{
    public class Geolocation
    {
         
        public double Latitude { get; set; } 
        public double Longitude { get; set;} 
                
        public double GetLatitude()
        {
            return this.Latitude;
        }

        public double GetLongitude()
        {
            return this.Longitude;
        }

        public void SetLatitude(double Latitude)
        {
            this.Latitude = Latitude;
        }

        public void SetLongitude(double Longitude)
        {
            this.Longitude= Longitude;
        }




    }
}
