using System.Collections.Generic;

namespace TeenPatti.Server
{
    public interface ITableManager
    {
        List<Table> GetAllTables();

        Table Get(long tableId);
    }
}