using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeenPatti.Manager
{
    public interface IMessageSendingManager
    {
        void Send(object message, long playerId);
    }
}
