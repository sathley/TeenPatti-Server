using TeenPatti.Model;

namespace TeenPatti.Managers
{
    public interface IPlayerManager
    {
        Player Create(Player player);
        Player Get(long playerId);
        Player Update(Player player, long playerId);
        void Delete(long playerId);
        bool ValidateSession(string token);
        void InValidateSession(string token);
        string GetSecretQuestion(string playerId);
        string Authenticate(Credentials request);
    }
}