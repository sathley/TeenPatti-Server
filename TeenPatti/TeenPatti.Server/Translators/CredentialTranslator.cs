namespace TeenPatti.Server
{
    public static class CredentialTranslator
    {
        public static TeenPatti.Server.Credentials ToDomainModel(this DataContracts.Credentials credentials)
        {
            if (credentials is DataContracts.UsernamePasswordCredentials)
            {
                var cred = credentials as DataContracts.UsernamePasswordCredentials;
                return new UsernamePasswordCredentials()
                {
                    Username = cred.Username,
                    Password = cred.Password
                };
            }
            else if (credentials is DataContracts.SecretAnswerCredentials)
            {
                var cred = credentials as DataContracts.SecretAnswerCredentials;
                return new SecretAnswerCredentials()
                {
                    Username = cred.Username,
                    SecretAnswer = cred.SecretAnswer
                };
            }
            else if (credentials is DataContracts.TokenCredentials)
            {
                var cred = credentials as DataContracts.TokenCredentials;
                return new TokenCredentials()
                {
                    Token = cred.Token
                };
            }
            else if (credentials is DataContracts.FacebookCredentials)
            {
                var cred = credentials as DataContracts.FacebookCredentials;
                var model = new OAuthCredentials() { Type = "facebook" };
                model["accesstoken"] = cred.AccessToken;
                model.Attributes.AddOrUpdateRange(cred.Attributes);
                return model;
            }
            else if (credentials is DataContracts.TwitterCredentials)
            {
                var cred = credentials as DataContracts.TwitterCredentials;
                var model = new OAuthCredentials() { Type = "twitter" };
                model["oauthtoken"] = cred.OAuthToken;
                model["oauthtokensecret"] = cred.OAuthTokenSecret;
                model.Attributes.AddOrUpdateRange(cred.Attributes);
                return model;
            }
            else return null;
        }
    }
}
