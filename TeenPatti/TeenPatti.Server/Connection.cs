using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace TeenPatti.Server
{
    public class Connection : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            
            return base.OnConnected(request, connectionId);
        }

        

        protected override Task OnReconnected(IRequest request, string connectionId)
        {
            
            return base.OnReconnected(request, connectionId);
        }

        protected override Task OnDisconnected(IRequest request, string connectionId)
        {
            
            return base.OnDisconnected(request, connectionId);
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            
            return base.OnReceived(request, connectionId, data);
        }
    }
}
