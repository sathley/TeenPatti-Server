namespace TeenPatti.Server
{
    public interface IMessageHandler
    {
        void HandleMessage(dynamic messageBody, long playerId);
    }
}