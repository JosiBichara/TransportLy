using System;
using TransportLy.Model;
using TransportLy.Data;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using TransportLy.Services;

namespace TransportLy
{
    class Program
    {
		
        static void Main(string[] args)
        {
            const int numberDays  = 2;
			var orders = OrderRepository.Get();

			Management management = new Management();

			Console.WriteLine($"USER STORY #1");
			List<Flight> flights = management.ScheduleFlighs(numberDays);
			
			Console.WriteLine($"USER STORY #2");
			management.AllocateOrders(flights, orders); 
			
        }

    }
}
