using System;
using TeenPatti.DataContracts;
using TeenPatti.Infrastructure;
using TeenPatti.Managers;
using TeenPatti.Translators;

namespace TeenPatti.Server
{
    public class PlayerService : IPlayer
    {
        public IIdGenerator IdGenerator { get; set; }

        public PlayerManager Manager { get; set; }

        public PlayerService()
        {
            this.IdGenerator = new RaindropMIG();
            this.Manager = new PlayerManager();
        }

        public PlayerResult Create(DataContracts.Player player)
        {
            var id = IdGenerator.GetNextId();
            player.Id = id;
            var modelPlayer = player.ToDomainModel();
            ValidatePlayer(ref modelPlayer);
            var result = Manager.Create(modelPlayer);
            return new PlayerResult()
                {
                    Player = result.ToDataModel(),
                    Status = new Status(){Code = "200"}
                };
        }

        private static void ValidatePlayer(ref TeenPatti.Model.Player modelPlayer)
        {
            modelPlayer.Bank = 10000;
            if(string.IsNullOrEmpty(modelPlayer.Username))
                throw new Exception("Username cannot be null or empty");
            if (string.IsNullOrEmpty(modelPlayer.Password))
                throw new Exception("Password cannot be null or empty");
            
        }

        public PlayerResult Get(string playerId)
        {
            return new PlayerResult()
                {
                    Player = Manager.Get(long.Parse(playerId)).ToDataModel(),
                    Status = new Status(){Code = "200"}
                };
        }

        public PlayerResult Update(DataContracts.Player player, string playerId)
        {
            throw new NotImplementedException();
        }

        public Result Delete(string playerId)
        {
            Manager.Delete(long.Parse(playerId));
            return new Result(){Status = new Status(){Code = "200"}};
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
            var creds = request.Credentials.ToDomainModel() as Model.SecretAnswerCredentials;
            if (creds != null)
            {
                var token = creds.Authenticate();
                if (token != null)
                {
                    return new AuthenticationResult()
                        {
                            Token = token,
                            Status = new Status(){Code = "200"}
                        };
                }
            }
            return new AuthenticationResult()
                {
                    Token = null,
                    Status = new Status()
                        {
                            Code = "400"
                        }
                };
        }
    }
}
