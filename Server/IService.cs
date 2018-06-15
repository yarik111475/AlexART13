﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using Model;

namespace Server {
    [ServiceContract]
    public interface IService {
        [OperationContract(IsOneWay = true)]
        void Receive(ObjectModel obj);
    }
}
