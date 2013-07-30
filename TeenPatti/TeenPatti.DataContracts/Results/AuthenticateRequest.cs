using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.DataContracts
{
    [DataContract]
    public class AuthenticateRequest
    {
        [DataMember]
        public Credentials Credentials { get; set; }
    }
}
