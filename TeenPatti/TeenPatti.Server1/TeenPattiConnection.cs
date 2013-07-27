using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using TeenPatti.Infrastructure;
using TeenPatti.Interfaces;

namespace TeenPatti.Server
{
    public class TeenPattiConnection : PersistentConnection
    {
        private IDatabase _database;
        private ISessionDatabase _sessionDatabase;

        public TeenPattiConnection()
        {
            _database = new InMemoryDB.InMemoryDB();
            _sessionDatabase = new InMemoryDB.InMemoryDB();
        }

        protected override Task OnConnected(IRequest request, string connectionId)
        {
            _database.AddConnection(connectionId);    
            return base.OnConnected(request, connectionId);
        }

        

        protected override Task OnReconnected(IRequest request, string connectionId)
        {
            
            return base.OnReconnected(request, connectionId);
        }

        protected override Task OnDisconnected(IRequest request, string connectionId)
        {
            var userId = _database.GetUser(connectionId);
            _sessionDatabase.InValidate(userId);
            _database.RemoveConnection(connectionId);
            return base.OnDisconnected(request, connectionId);
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            dynamic message = JsonConvert.DeserializeObject(data);
            IMessageHandler handler = MessageHandlerManager.GetHandler(message.Type??"");
            var playerId = _sessionDatabase.Authenticate(message.SessionToken??"");

            if(handler!=null && playerId!=0)
                handler.HandleMessage(message.Body, playerId);
            
            return base.OnReceived(request, connectionId, data);
        }
    }
}
