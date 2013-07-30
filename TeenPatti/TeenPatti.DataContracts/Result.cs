using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.DataContracts
{
    [DataContract]
    public class Result
    {
        public Result()
        {
            this.Status = new Status();
        }

        [DataMember(Order = 0)]
        public Status Status { get; set; }

    }
}
