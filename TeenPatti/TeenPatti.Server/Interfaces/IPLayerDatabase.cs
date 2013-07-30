namespace TeenPatti.Server
{
    public interface IPlayerDatabase
    {
        Player Create(Player player);

        Player Update(long playerId, Player player);

        void Delete(long playerId);

        Player Get(long playerId);

        Player Get(string username, string secretPasswordHash);
    }
}
