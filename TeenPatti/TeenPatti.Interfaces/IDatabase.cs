using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.Interfaces
{
    public interface IDatabase
    {
        void AddConnection(string connectionId);

        void RemoveConnection(string connectionId);

        string GetConnection(long playerId);

        long GetUser(string connectionId);
    }
}
