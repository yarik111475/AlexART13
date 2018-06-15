using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Server {
    class Program {
        static void Main(string[] args) {
            Uri address = new Uri("http://localhost:8090/Service");
            using (ServiceHost host = new ServiceHost(typeof(Service), address)) {
                host.AddServiceEndpoint(typeof(IService), new BasicHttpBinding(), "");
                host.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });
                host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
                host.Opening += Host_Opening; host.Opened += Host_Opened;
                host.Open();
                Console.ReadLine();
            }
        }

        private static void Host_Opened(object sender, EventArgs e) {
            Console.WriteLine("service is ready...");
        }

        private static void Host_Opening(object sender, EventArgs e) {
            Console.WriteLine("opening service...");
        }
    }
}
