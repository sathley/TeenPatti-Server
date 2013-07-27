using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeenPatti.Interfaces;

namespace TeenPatti.Infrastructure
{
    public static class MessageHandlerManager
    {
        public static Dictionary<string, IMessageHandler> Handlers=new Dictionary<string, IMessageHandler>();

        static MessageHandlerManager()
        {
            Handlers.Add("get_tables", new GetTablesHandler());
        }

        public static IMessageHandler GetHandler(string messageType)
        {
            IMessageHandler handler;
            Handlers.TryGetValue(messageType, out handler);
            return handler;
        }
    }

    

}
