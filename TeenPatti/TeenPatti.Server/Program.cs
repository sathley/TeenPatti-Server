using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using Alchemy.Classes;
using Newtonsoft.Json;
using System.Net;

using Alchemy;
using Alchemy.Handlers;
using Alchemy.Handlers.WebSocket;
using TeenPatti.Infrastructure;
using TeenPatti.Manager;

namespace TeenPatti.Server
{
    public class Program
    {
        public static Configuration config = new Configuration();
        public static IWebSocketManager manager = new WebSocketTestManager();
        public static WebSocketServer server;

        public static void Main(string[] args)
        {
            var config = new Configuration();
            var manager = new WebSocketManager();
            server = new Alchemy.WebSocketServer(config.ServerPort, IPAddress.Any)
                {
                    OnConnected = OnConnected,
                    OnConnect = OnConnect,
                    OnDisconnect = OnDisconnect,
                    OnReceive = OnRecieve,
                    OnSend = OnSend,
                    TimeOut = new TimeSpan(1, 1, 1, 1)

                };
            server.Start();
            Console.ReadKey(true);
        }

        private static void OnSend(UserContext context)
        {

        }

        private static void OnRecieve(UserContext context)
        {
            var ep = context.ClientAddress as IPEndPoint;
            context.Send("msg rcv");
            var cxt = new UserContext(new Context(server, new TcpClient(ep)));
            cxt.Send("wowowo");
        }

        private static void OnDisconnect(UserContext context)
        {

        }

        private static void OnConnect(UserContext context)
        {

        }

        private static void OnConnected(UserContext context)
        {

        }
    }
}

