using System;
using TeenPatti.DataAccess;
using TeenPatti.Model;

namespace TeenPatti.Managers
{
    public class PlayerManager
    {
        public PlayerManager()
        {
            this.Storage = new PlayerStorage();
        }

        private IPlayerStorage Storage { get; set; }

        public Player Create(Player player)
        {
            return this.Storage.Create(player);
        }

        public Player Get(long playerId)
        {
            throw new NotImplementedException();
        }

        public Player Update(Player player, long playerId)
        {
            throw new NotImplementedException();
        }

        public void Delete(long playerId)
        {
            throw new NotImplementedException();
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
