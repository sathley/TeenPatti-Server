using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.DataContracts
{
    [DataContract]
    public class Status
    {
        public static readonly string SuccessCode = "200";
        public static readonly string SuccessMessage = "Successful";

        public Status()
        {
            this.ReferenceId = Guid.NewGuid().ToString();
            this.AdditionalMessages = new List<string>();
            this.Message = SuccessMessage;
            this.Code = SuccessCode;
        }

        [DataMember(EmitDefaultValue = false, Name = "code")]
        public string Code { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "message")]
        public string Message { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "faulttype")]
        public string FaultType { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "version")]
        public string Version { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "referenceid")]
        public string ReferenceId { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "additionalmessages")]
        public List<string> AdditionalMessages { get; set; }

        public override string ToString()
        {
            return "Status Code: " + this.Code + ". Status Message: " + this.Message +
                   ". Additional Message: " + this.AdditionalMessages;
        }
    }
}
