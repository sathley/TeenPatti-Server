using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace TeenPatti.Server
{
    public class InMemoryDB : IDatabase, ISessionDatabase, IPlayerDatabase
    {
        public static ConcurrentDictionary<string,long> UserSessions=new ConcurrentDictionary<string, long>(); 

        public static ConcurrentDictionary<long,string> UserConnections=new ConcurrentDictionary<long, string>(); 

        public static ConcurrentDictionary<long, Game> Tables=new ConcurrentDictionary<long, Game>();

        public static ConcurrentDictionary<long, Player> Players=new ConcurrentDictionary<long, Player>(); 

        public void AddConnection(string connectionId)
        {
            UserConnections.TryAdd(-1,connectionId);
        }

        public void RemoveConnection(string connectionId)
        {
            throw new NotImplementedException();
        }

        public long GetUser(string connectionId)
        {
            long userId = 0;
            foreach (var userConnection in UserConnections)
            {
                if (userConnection.Value.Equals(connectionId))
                    userId = userConnection.Key;
            }
            return userId;
        }

        public List<Game> GetAllTables()
        {
            return Tables.Select(table => table.Value).ToList();
        }

        public Game GetTable(long tableId)
        {
            return Tables[tableId];
        }

        //public void RemoveConnection(string connectionId)
        //{
        //    long userId;
        //    UserConnections.TryRemove(connectionId, out userId);
        //}

        public string GetConnection(long playerId)
        {
            string connectionId;
            UserConnections.TryGetValue(playerId, out connectionId);
            return connectionId;
        }

        public long Authenticate(string sessionToken)
        {
            long playerId;
            UserSessions.TryGetValue(sessionToken, out playerId);
            return playerId;
        }

        public void InValidate(string sessionToken)
        {
            long playerId;
            UserSessions.TryRemove(sessionToken, out playerId);
        }

        public string CreateSession(long playerId)
        {
            var sessionToken = Guid.NewGuid().ToString();
            UserSessions.TryAdd(sessionToken, playerId);
            return sessionToken;
        }

        public void InValidate(long userId)
        {
            string sessionToken = string.Empty;
            long uId;
            foreach (var userSession in UserSessions)
            {
                if (userSession.Value.Equals(userId))
                    sessionToken = userSession.Key;
            }
            UserSessions.TryRemove(sessionToken, out uId);
        }

        public Player Create(Player player)
        {
            var result = Players.TryAdd(player.Id, player);
            return result ? player : null;
        }

        public Player Update(long playerId, Player player)
        {
            Player existingPlayer;
            Players.TryGetValue(playerId, out existingPlayer);
            var result = Players.TryUpdate(playerId, player, existingPlayer);
            return player;
        }

        public void Delete(long playerId)
        {
            Player player;
            Players.TryRemove(playerId, out player);
        }

        public Player Get(long playerId)
        {
            Player player;
            Players.TryGetValue(playerId, out player);
            return player;
        }

        public Player Get(string username, string secretPasswordHash)
        {
            foreach (var player in Players)
            {
                if (player.Value.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase) &&
                    player.Value.Password.Equals(secretPasswordHash))
                    return player.Value;
            }
            return null;
        }
    }
}
