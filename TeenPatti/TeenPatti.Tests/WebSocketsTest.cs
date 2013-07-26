using System;
using System.Net;
using Alchemy;
using Alchemy.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeenPatti.Tests
{
    [TestClass]
    public class WebSocketsTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var server = new WebSocketServer(8080, IPAddress.Any)
            {
                OnConnected = OnConnected,
                OnConnect = OnConnect,
                OnDisconnect = OnDisconnect,
                OnReceive = OnRecieve,
                OnSend = OnSend

            };
            server.Start();
            
        }

        private static void OnSend(UserContext context)
        {
            
        }

        private static void OnRecieve(UserContext context)
        {
           
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
