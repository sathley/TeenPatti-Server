namespace TeenPatti.Interfaces
{
    public interface IMessageSendingManager
    {
        void Send(object message, long playerId);
    }
}
