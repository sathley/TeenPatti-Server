using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using TeenPatti.Interfaces;
using TeenPatti.Server;

namespace TeenPatti.Manager
{
    public class MessageSendingManager : IMessageSendingManager
    {
        private readonly IDatabase _database =new InMemoryDB.InMemoryDB();

        public void Send(object message, long playerId)
        {
            var context = GlobalHost.ConnectionManager.GetConnectionContext<TeenPattiConnection>();
            var connectionId = _database.GetConnection(playerId);
            context.Connection.Send(connectionId, message);
        }
    }
}
