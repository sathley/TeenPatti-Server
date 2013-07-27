namespace TeenPatti.Server
{
    public interface IMessageSendingManager
    {
        void Send(object message, long playerId);
    }
}
