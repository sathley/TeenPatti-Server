using System;
using TeenPatti.DataAccess;
using TeenPatti.Model;

namespace TeenPatti.Managers
{
    public class PlayerManager : IPlayerManager
    {
        public PlayerManager()
        {
            this.Storage = new PlayerStorage();
        }

        private IPlayerStorage Storage { get; set; }

        public Player Create(Player player)
        {
            return this.Storage.Create(player).Result;
        }

        public Player Get(long playerId)
        {
            return this.Storage.Get(playerId).Result;
        }

        public Player Update(Player player, long playerId)
        {
            throw new NotImplementedException();
        }

        public void Delete(long playerId)
        {
            this.Storage.Delete(playerId);
        }

        public bool ValidateSession(string token)
        {
            throw new NotImplementedException();
        }

        public void InValidateSession(string token)
        {
            throw new NotImplementedException();
        }

        public string GetSecretQuestion(string playerId)
        {
            throw new NotImplementedException();
        }

        public string Authenticate(Credentials request)
        {
            throw new NotImplementedException();
        }
    }
}
