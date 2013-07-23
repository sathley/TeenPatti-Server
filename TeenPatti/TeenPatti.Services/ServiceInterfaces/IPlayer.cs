using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TeenPatti.Services
{
    [ServiceContract]
    public interface IPlayer
    {
        [OperationContract]
        string GetData(int value);
    }

    
}
