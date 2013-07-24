using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.DataContracts
{
    [DataContract]
    public class AuthenticationResult : Result
    {
        [DataMember]
        public string Token { get; set; }

        [DataMember]
        public Player Player { get; set; }

        [DataMember]
        public string ExpiryCount { get; set; }

        [DataMember]
        public string ExpiryDuration { get; set; }
    }
}
