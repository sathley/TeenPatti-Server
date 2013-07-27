//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Sockets;
//using System.Web.Routing;
//using Alchemy.Classes;
//using Microsoft.AspNet.SignalR;
//using Newtonsoft.Json;
//using System.Net;

//using Alchemy;
//using Alchemy.Handlers;
//using Alchemy.Handlers.WebSocket;
//using TeenPatti.Infrastructure;
//using TeenPatti.Manager;

//namespace TeenPatti.Server
//{
//    public class Program
//    {
//        public static Configuration config = new Configuration();
//        public static IWebSocketManager manager = new WebSocketTestManager();
//        public static WebSocketServer server;

//        public static void Main(string[] args)
//        {
//            var config = new Configuration();
//            var manager = new WebSocketManager();
//            // Code that runs on application startup
//            RouteTable.Routes.MapConnection("connection", "/connection", typeof(Connection), new ConnectionConfiguration() { EnableCrossDomain = true });
//            Console.ReadKey(true);
//        }
//    }
//}

