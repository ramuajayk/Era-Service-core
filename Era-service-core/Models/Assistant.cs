using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Era_service_core.Models
{
    public class Assistant
    {
        private string name;
        private Geolocation location;

        public Assistant(string name, Geolocation location)
        {
            this.name = name;
            this.location = location;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public Geolocation GetLocation()
        {
            return location;
        }

        public void SetLocation(Geolocation location)
        {
            this.location = location;
        }
    }
}
