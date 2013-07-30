using System;
using TeenPatti.DataContracts;

namespace TeenPatti.Server
{
    public class PlayerService : IPlayer
    {
        public IPlayerDatabase PlayerDatabase { get; set; }

        public IIdGenerator IdGenerator { get; set; }
        public PlayerService()
        {
            this.PlayerDatabase = new InMemoryDB();
            this.IdGenerator = new RaindropMIG();
        }

        public PlayerResult Create(DataContracts.Player player)
        {
            var id = IdGenerator.GetNextId();
            player.Id = id;
            var modelPlayer = player.ToDomainModel();
            ValidatePlayer(ref modelPlayer);
            var result = PlayerDatabase.Create(modelPlayer);
            return new PlayerResult()
                {
                    Player = result.ToDataModel(),
                    Status = new Status(){Code = "200"}
                };
        }

        private static void ValidatePlayer(ref Player modelPlayer)
        {
            modelPlayer.Bank = 10000;
            
        }

        public PlayerResult Get(string playerId)
        {
            return new PlayerResult()
                {
                    Player = PlayerDatabase.Get(long.Parse(playerId)).ToDataModel(),
                    Status = new Status(){Code = "200"}
                };
        }

        public PlayerResult Update(DataContracts.Player player, string playerId)
        {
            throw new NotImplementedException();
        }

        public Result Delete(string playerId)
        {
            PlayerDatabase.Delete(long.Parse(playerId));
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
            var creds = request.Credentials.ToDomainModel() as SecretAnswerCredentials;
            var token = creds.Authenticate();
            if (token != null)
            {
                return new AuthenticationResult()
                    {
                        Token = token,
                        Status = new Status(){Code = "200"}
                    };
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
