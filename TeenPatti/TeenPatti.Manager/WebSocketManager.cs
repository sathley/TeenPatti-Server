using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.Manager
{
    public interface IWebSocketManager
    {
        void OnSend(WebSocketInfo info);
        void OnRecieve(WebSocketInfo info);
        void OnDisconnect(WebSocketInfo info);
        void OnConnect(WebSocketInfo info);
        void OnConnected(WebSocketInfo info);
    }

    public class WebSocketTestManager : IWebSocketManager
    {

        public void OnSend(WebSocketInfo info)
        {
            throw new NotImplementedException();
        }

        public void OnRecieve(WebSocketInfo info)
        {
            throw new NotImplementedException();
        }

        public void OnDisconnect(WebSocketInfo info)
        {
            throw new NotImplementedException();
        }

        public void OnConnect(WebSocketInfo info)
        {
            throw new NotImplementedException();
        }

        public void OnConnected(WebSocketInfo info)
        {
            throw new NotImplementedException();
        }
    }

    public class WebSocketManager : IWebSocketManager
    {
        public void OnSend(WebSocketInfo info)
        {
            
        }

        public void OnRecieve(WebSocketInfo info)
        {

        }

        public void OnDisconnect(WebSocketInfo info)
        {

        }

        public void OnConnect(WebSocketInfo info)
        {

        }

        public void OnConnected(WebSocketInfo info)
        {

        }
    }

    public class WebSocketInfo
    {
        public string Data { get; set; }

        public EndPoint EndPoint { get; set; }

        public string Path { get; set; }
    }


}
