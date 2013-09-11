using System.Threading.Tasks;

namespace TeenPatti.Model
{
    public interface IPlayerStorage
    {
        Task<Player> Create(Player player);

        Task<Player> Get(long playerId);

        Task<Player> Update(Player player, long playerId);

        void Delete(long playerId);
    }
}
