using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.DataContracts
{
    [DataContract]
    public class KeyValue
    {
        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public string Value { get; set; }
    }
}
