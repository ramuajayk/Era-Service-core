using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Era_service_core.Models
{
    public class Customer
    {
        string name;
        public Customer(string name)
        {
            this.name = name;
        }

        public string Get()
        {
            return name;
        }

        public void Set(string name)
        {
            this.name = name;
        }

        
    }
}
