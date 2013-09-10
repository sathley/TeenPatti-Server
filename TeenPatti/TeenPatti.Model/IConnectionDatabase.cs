namespace TeenPatti.Model
{
    public interface IConnectionDatabase
    {
        void AddConnection(string connectionId);

        void RemoveConnection(string connectionId);

        string GetConnection(long playerId);

        long GetUser(string connectionId);

        
    }
}