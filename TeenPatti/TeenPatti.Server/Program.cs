using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Alchemy.Classes;
using Newtonsoft.Json;
using System.Net;

using Alchemy;
using Alchemy.Handlers;
using Alchemy.Handlers.WebSocket;
using TeenPatti.Infrastructure;

namespace TeenPatti.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new Configuration();
            var server = new Alchemy.WebSocketServer(config.ServerPort, IPAddress.Any)
                {
                    OnConnected = OnConnected,
                    OnConnect = OnConnect,
                    OnDisconnect = OnDisconnect,
                    OnReceive = OnRecieve,
                    OnSend = OnSend
                };
        }

        private static void OnSend(UserContext context)
        {
            throw new NotImplementedException();
        }

        private static void OnRecieve(UserContext context)
        {
            throw new NotImplementedException();
        }

        private static void OnDisconnect(UserContext context)
        {
            throw new NotImplementedException();
        }

        private static void OnConnect(UserContext context)
        {
            throw new NotImplementedException();
        }

        private static void OnConnected(UserContext context)
        {
            throw new NotImplementedException();
        }
    }
}

