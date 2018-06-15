using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using Model;

namespace Server {
    public class Service : IService {
        public void Receive(ObjectModel obj) {
            Console.WriteLine("ObjectId: {0}; Id: {1}; Name: {2}; Description: {3}",
                obj.ObjectID, obj.ID, obj.Name, obj.Description);
        }
    }
}
