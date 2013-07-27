using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeenPatti.Interfaces;
using TeenPatti.Model;

namespace TeenPatti.InMemoryDB
{
    public class InMemoryDB : IDatabase, ISessionDatabase
    {
        public static ConcurrentDictionary<string,long> UserSessions=new ConcurrentDictionary<string, long>(); 

        public static ConcurrentDictionary<long,string> UserConnections=new ConcurrentDictionary<long, string>(); 

        public static ConcurrentDictionary<long, TableManager> TableManagers=new ConcurrentDictionary<long, TableManager>();

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
    }
}
