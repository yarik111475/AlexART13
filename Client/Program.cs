using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using System.Reflection;

using Model;

namespace Client {
    class Program {
        static void Main(string[] args) {
            string address = "http://localhost:8090/Service";
            BasicHttpBinding binding = new BasicHttpBinding();
            IService proxy = ChannelFactory<IService>.CreateChannel(binding, new EndpointAddress(address));
            ObjectModelView obj = new ObjectModelView {
                ObjectID=0,
                ID=0,
                Name="name000",
                Description="description000"
            };

            proxy.Receive(obj);
            Console.ReadLine();
        }
    }
}
