using Era_service_core.Helpers;
using Era_service_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Era_service_core.Controller
{
    public class RoadsideAssistanceService :  IRoadsodeAssitanceService
    {

        Dictionary<Assistant, Geolocation> assistantLocations = new Dictionary<Assistant, Geolocation>();
        Dictionary<Customer, Assistant> reservedAssistants = new Dictionary<Customer, Assistant>();


        public void UpdateAssistantLocation(Assistant assistant, Geolocation location)
        {
            assistantLocations[assistant] = location;
        }

        public  SortedSet<Assistant> FindNearestAssistants(Geolocation location, int limit)
        {
            SortedSet<Assistant> nearestAssistants = new SortedSet<Assistant>(new AssistantDistanceComparer(location));

            foreach (Assistant assistant in assistantLocations.Keys)
            {
                double distance = DistanceOperation.CalculateDistance(location, assistant.GetLocation());
                if (distance <= limit)
                {
                    nearestAssistants.Add(assistant);
                }
            }
            return nearestAssistants;
        }

        public Assistant? ReserveAssistant(Customer customer, Geolocation customerLocation)
        {
            SortedSet<Assistant> nearestAssistants = FindNearestAssistants(customerLocation, int.MaxValue);
            foreach(Assistant assistant in nearestAssistants)
            {
                if (!reservedAssistants.ContainsValue(assistant))
                {
                    reservedAssistants.Add(customer, assistant);
                    return assistant;
                }
            }
            return null;
        }

        public void ReleaseAssistant(Customer customer, Assistant assistant)
        {
            reservedAssistants.Remove(customer);
        }



    }
}

