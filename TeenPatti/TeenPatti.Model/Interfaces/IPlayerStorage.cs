namespace TeenPatti.Model
{
    public interface IPlayerStorage
    {
        Player Create(Player player);

        Player Get(long playerId);

        Player Update(Player player, long playerId);

        void Delete(long playerId);
    }
}
