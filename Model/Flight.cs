using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportLy.Data;

namespace TransportLy.Model
{
    public class Flight
    {
        
        public Locations Arrival {get;set;}
        public Locations Departure {get; set;}
        public int Day {get; set;}
        public int Number {get; set;}
        public AirPlane AirPlane {get; set;}
        public List<object> Orders{get;set;}

        public Flight()
        {
            this.AirPlane = new AirPlane();
            this.Orders = new List<object>();
        }


        public Flight(int numberFlight, Locations departure, Locations arrival, int day) : this()
		{
			this.Number = numberFlight;
			this.Departure = departure;
			this.Arrival = arrival;
			this.Day = day;
		}

        public bool hasAvailability()
        {
            return (Orders?.Count < AirPlane?.Capacity);
        }

    }
}