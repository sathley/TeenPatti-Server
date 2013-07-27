using Microsoft.AspNet.SignalR;

namespace TeenPatti.Server
{
    public class MessageSendingManager : IMessageSendingManager
    {
        private readonly IDatabase _database =new InMemoryDB();

        public void Send(object message, long playerId)
        {
            var context = GlobalHost.ConnectionManager.GetConnectionContext<TeenPattiConnection>();
            var connectionId = _database.GetConnection(playerId);
            context.Connection.Send(connectionId, message);
        }
    }
}
