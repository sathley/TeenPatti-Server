using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.DataContracts
{
    [DataContract]
    public class SecretAnswerCredentials : Credentials
    {
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string SecretAnswer { get; set; }

    }

    [DataContract]
    public class UsernamePasswordCredentials : Credentials
    {
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }
    }


    [DataContract]
    public class FacebookCredentials : Credentials
    {
        public FacebookCredentials()
        {
            this.Attributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }


        [DataMember]
        public string AccessToken { get; set; }

        [DataMember]
        public Dictionary<string, string> Attributes { get; private set; }

        public string this[string attrName]
        {
            get
            {
                string value = null;
                if (this.Attributes.TryGetValue(attrName, out value) == true)
                    return value;
                else return null;
            }
            set { this.Attributes[attrName] = value; }
        }
    }

    [DataContract]
    public class TwitterCredentials : Credentials
    {
        public TwitterCredentials()
        {
            this.Attributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        [DataMember]
        public string OAuthToken { get; set; }

        [DataMember]
        public string OAuthTokenSecret { get; set; }

        [DataMember]
        public Dictionary<string, string> Attributes { get; private set; }

        public string this[string attrName]
        {
            get
            {
                string value = null;
                if (this.Attributes.TryGetValue(attrName, out value) == true)
                    return value;
                else return null;
            }
            set { this.Attributes[attrName] = value; }
        }
    }

    public class TokenCredentials : Credentials
    {
        [DataMember]
        public string Token { get; set; }
    }
}
