using System.Collections.Generic;

namespace TeenPatti.Model
{
    public interface ITableDatabase
    {
        List<Table> GetAllTables();

        Table GetTable(long tableId);
    }
}
