using System;
using System.Collections.Generic;

namespace TeenPatti.Model
{
    public class SecretAnswerCredentials : Credentials
    {

        public string Username { get; set; }


        public string SecretAnswer { get; set; }

        public override string Authenticate()
        {
            throw new NotImplementedException();
        }
    }


    public class UsernamePasswordCredentials : Credentials
    {

        public string Username { get; set; }


        public string Password { get; set; }

        public override string Authenticate()
        {
            //IPlayerDatabase playerDatabase = new InMemoryDB();
            //ISessionDatabase sessionDb = new InMemoryDB();
            //var player = playerDatabase.Get(this.Username, Md5.Hash(this.Password));
            //if (player == null) return null;
            //return sessionDb.CreateSession(player.Id);
            throw new NotImplementedException();
        }
    }



    public class FacebookCredentials : Credentials
    {
        public FacebookCredentials()
        {
            this.Attributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }



        public string AccessToken { get; set; }


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

        public override string Authenticate()
        {
            throw new NotImplementedException();
        }
    }


    public class TwitterCredentials : Credentials
    {
        public TwitterCredentials()
        {
            this.Attributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }


        public string OAuthToken { get; set; }


        public string OAuthTokenSecret { get; set; }


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

        public override string Authenticate()
        {
            throw new NotImplementedException();
        }
    }

    public class TokenCredentials : Credentials
    {

        public string Token { get; set; }

        public override string Authenticate()
        {
            throw new NotImplementedException();
        }
    }

    public class OAuthCredentials : Credentials
    {
        public OAuthCredentials()
        {
            this.Attributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        public string Type { get; set; }

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


        public override string Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}
