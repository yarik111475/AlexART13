using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

using Model;

namespace Client {
    [DataContract(Name = "ObjectModel", Namespace = "Model")]
    public class ObjectModelView : ObjectModel {
        [DataMember(Name = "Name")]
        public new string Name {
            get {
                return base.Name + "_ViewModelEdition";
            }
            set {
                base.Name = value;
            }
        }
    }
}
