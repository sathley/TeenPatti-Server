using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.DataContracts
{
    [DataContract]
    public class Player
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string SecretQuestion { get; set; }

        [DataMember]
        public string SecretAnswer { get; set; }

        [DataMember]
        public string SecretAnswerHash { get; set; }

        [DataMember]
        public DateTime UtcJoiningDate { get; set; }

        [DataMember]
        public bool IsEnabled { get; set; }

        [DataMember]
        public KeyValue[] Attributes { get; set; }

        public Dictionary<string, string> Items { get; set; }

        [OnDeserializing]
        public void OnDeserializing(StreamingContext c)
        {
            this.Items = new Dictionary<string, string>();
        }

        [OnDeserialized]
        public void OnDeserialized(StreamingContext c)
        {
            if (this.Items == null)
                this.Items = new Dictionary<string, string>();

            if (this.Attributes != null && Attributes.Length > 0)
                Array.ForEach(this.Attributes, attribute =>
                {
                    Items[attribute.Key] = attribute.Value;
                });
        }

        [OnSerializing]
        public void OnSerializing(StreamingContext c)
        {
            if (Items != null)
            {
                this.Attributes = Items
                    .Select(item => new KeyValue()
                    {
                        Key = item.Key,
                        Value = item.Value
                    }).ToArray();
            }
            else
                this.Items = new Dictionary<string, string>();

            if (this.UtcJoiningDate == DateTime.MinValue)
                this.UtcJoiningDate = new DateTime(2000, 01, 01);
        }
    }
}
