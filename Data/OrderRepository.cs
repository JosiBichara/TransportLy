using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportLy.Model;
using Newtonsoft.Json;
using System.Web;
 


namespace TransportLy.Data
{
    public class OrderRepository
    {

        
        public static dynamic Get()
        {
            
            dynamic listOrder = null;
            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/orders.json")))
                {
                    string jsonString = sr.ReadToEnd();
                    listOrder = JsonConvert.DeserializeObject(jsonString);
                }
                             
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
    
             return listOrder;  
        }
    }
}