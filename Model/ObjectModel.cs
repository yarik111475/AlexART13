using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Model {
    [DataContract(Name = "ObjectModel", Namespace = "Model")]
    public class ObjectModel : DBObject {
        public int ObjectID { get; set; }
    }
}
