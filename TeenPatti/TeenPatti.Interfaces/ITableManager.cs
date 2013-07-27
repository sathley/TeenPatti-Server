using System.Collections.Generic;
using TeenPatti.Model;

namespace TeenPatti.Interfaces
{
    public interface ITableManager
    {
        List<Table> GetAllTables();

        Table Get(long tableId);
    }
}