using System.Collections.Generic;

namespace TeenPatti.Server
{
    public interface IDatabase
    {
        void AddConnection(string connectionId);

        void RemoveConnection(string connectionId);

        string GetConnection(long playerId);

        long GetUser(string connectionId);

        List<Game> GetAllTables();

        Game GetTable(long tableId);
    }
}
