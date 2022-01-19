using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TransportLy.Model;

namespace TransportLy.Services
{
    public class Management
    {

        public Management(){

        }
        public List<Flight> ScheduleFlighs(int numberDays)
        {
            List<Flight> flights = new List<Flight>();
            for( int i = 1; i <= numberDays; i++)
            {
                flights.Add(new Flight(flights.Count + 1, Locations.YUL, Locations.YYZ, i));
                flights.Add(new Flight(flights.Count + 1, Locations.YUL, Locations.YYC, i));
                flights.Add(new Flight(flights.Count + 1, Locations.YUL, Locations.YVR, i));
            }

            flights.ForEach( T => Console.WriteLine($"Flight: {T.Number}, departure: {T.Departure}, arrival: {T.Arrival}, day: {T.Day}"));

            return flights;

        }


        public void AllocateOrders(List<Flight> flights, JToken orders)
        {
            if(orders != null)
            {
                foreach(JProperty item in orders)
                {
                    
                    if(Enum.TryParse<Locations>(item.Value["destination"].ToString(), true,  out var location)){

                        Flight currentFlight = flights.FirstOrDefault( t => t.Arrival == location && t.hasAvailability());
                        if(currentFlight != null)
                        {
                           currentFlight.Orders.Add(item);
                        }

                        Console.WriteLine($"order: {item.Name}, flightNumber: {currentFlight.Number}, departure: {currentFlight.Departure}, arrival: {currentFlight.Arrival}, day: {currentFlight.Day}");
                    
                    }
                    else
                    {
                        Console.WriteLine($"order: {item.Name}, flightNumber: not scheduled");
                    }
                    
                }
            }
        }

    }
}