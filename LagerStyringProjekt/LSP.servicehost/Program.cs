using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSP.service;
using System.ServiceModel;

namespace LSP.servicehost
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost host = new ServiceHost(typeof(LSPService), new Uri("http://localhost:8000/"));
            host.Open();
            Console.WriteLine("Host is running on: " + host.BaseAddresses.First());

            //WebServiceHost hostjson = new WebServiceHost(typeof(Service), new Uri("http://localhost:8000/api/json/"));
            //ServiceEndpoint epjson = hostjson.AddServiceEndpoint(typeof(IServiceJson), new WebHttpBinding(), "");

            //ServiceDebugBehavior sdbjson = hostjson.Description.Behaviors.Find<ServiceDebugBehavior>();
            //sdbjson.HttpHelpPageEnabled = false;

    
            Console.WriteLine("Servicen blev startet!");
            Console.WriteLine("Skriv \"quit!\" for at stoppe servicen...");

            while (Console.ReadLine().ToString() != "quit!")
            {
                Console.WriteLine("Skriv \"quit!\" for at stoppe servicen...");
            }
            host.Close();
        }
    }
}
