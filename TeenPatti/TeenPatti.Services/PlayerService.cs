using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TeenPatti.DataContracts;

namespace TeenPatti.Services
{
    public class PlayerService : IPlayer
    {
        public PlayerResult Create(Player player)
        {
            throw new NotImplementedException();
        }

        public PlayerResult Get(string playerId)
        {
            throw new NotImplementedException();
        }

        public PlayerResult Update(Player player, string playerId)
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
    }
}
