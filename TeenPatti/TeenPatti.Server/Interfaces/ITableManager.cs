using System.Collections.Generic;

namespace TeenPatti.Server
{
    public interface ITableManager
    {
        List<Game> GetAllTables();

        Game Get(long tableId);
    }
}