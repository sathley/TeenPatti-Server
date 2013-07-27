namespace TeenPatti.Interfaces
{
    public interface IMessageHandler
    {
        void HandleMessage(dynamic messageBody, long playerId);
    }
}