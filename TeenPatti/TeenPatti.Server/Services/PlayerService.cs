using System;
using TeenPatti.DataContracts;

namespace TeenPatti.Server
{
    public class PlayerService : IPlayer
    {
        public PlayerResult Create(DataContracts.Player player)
        {
            throw new NotImplementedException();
        }

        public PlayerResult Get(string playerId)
        {
            throw new NotImplementedException();
        }

        public PlayerResult Update(DataContracts.Player player, string playerId)
        {
            throw new NotImplementedException();
        }

        public Result Delete(string playerId)
        {
            throw new NotImplementedException();
        }

        public BooleanResult ValidateSession(string token)
        {
            throw new NotImplementedException();
        }

        public Status InValidateSession(string token)
        {
            throw new NotImplementedException();
        }

        public StringResult GetSecretQuestion(string playerId)
        {
            throw new NotImplementedException();
        }

        public AuthenticationResult Authenticate(AuthenticateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
