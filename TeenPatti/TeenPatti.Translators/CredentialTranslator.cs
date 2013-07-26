using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeenPatti.Model;
using Domain = TeenPatti.Model;
using Data = TeenPatti.DataContracts;

namespace TeenPatti.Translators
{
    public static class CredentialTranslator
    {
        public static Domain.Credentials ToDomainModel(this Data.Credentials credentials)
        {
            if (credentials is Data.UsernamePasswordCredentials)
            {
                var cred = credentials as Data.UsernamePasswordCredentials;
                return new Domain.UsernamePasswordCredentials()
                {
                    Username = cred.Username,
                    Password = cred.Password
                };
            }
            else if (credentials is Data.SecretAnswerCredentials)
            {
                var cred = credentials as Data.SecretAnswerCredentials;
                return new Domain.SecretAnswerCredentials()
                {
                    Username = cred.Username,
                    SecretAnswer = cred.SecretAnswer
                };
            }
            else if (credentials is Data.TokenCredentials)
            {
                var cred = credentials as Data.TokenCredentials;
                return new Domain.TokenCredentials()
                {
                    Token = cred.Token
                };
            }
            else if (credentials is Data.FacebookCredentials)
            {
                var cred = credentials as Data.FacebookCredentials;
                var model = new Domain.OAuthCredentials() { Type = "facebook" };
                model["accesstoken"] = cred.AccessToken;
                model.Attributes.AddOrUpdateRange(cred.Attributes);
                return model;
            }
            else if (credentials is Data.TwitterCredentials)
            {
                var cred = credentials as Data.TwitterCredentials;
                var model = new Domain.OAuthCredentials() { Type = "twitter" };
                model["oauthtoken"] = cred.OAuthToken;
                model["oauthtokensecret"] = cred.OAuthTokenSecret;
                model.Attributes.AddOrUpdateRange(cred.Attributes);
                return model;
            }
            else return null;
        }
    }
}
