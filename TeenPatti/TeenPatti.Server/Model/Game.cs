using System.Collections.Generic;

namespace TeenPatti.Server
{
    public class Game
    {
        public long Id { get; set; }

        public int Capacity { get; set; }

        public long BootValue { get; set; }

        public TableState TableState { get; set; }

        public VariationType VariationType { get; set; }

        public List<SeatedPlayer> SeatedPlayers { get; set; }

        public long MinimumBankRequired { get; set; }

        public int MinimumPlayersRequired { get; set; }

        public static List<Game> GetAllTables()
        {
            IDatabase database = new InMemoryDB();
            return database.GetAllTables();
        }

        public static TableState GetTableState(long tableId)
        {
            IDatabase database = new InMemoryDB();
            return database.GetTable(tableId).TableState;
        }

        public static bool MayISit(long playerId, long tableId, int position)
        {
            IDatabase database = new InMemoryDB();
            var table = database.GetTable(tableId);
            if (table.SeatedPlayers.Count >= table.Capacity)
                return false;

            var player = Player.Get(playerId);

            if (player == null)
                return false;

            if (player.Bank < table.MinimumBankRequired)
                return false;

            table.SeatedPlayers.Add(new SeatedPlayer(){PlayerId = playerId,Position = position});
            if(table.TableState == TableState.WaitingForPlayers && table.SeatedPlayers.Count >= table.MinimumPlayersRequired)
                InitiateGameplay(table.Id);
            return true;
        }

        private static void InitiateGameplay(long tableId)
        {
            IDatabase database = new InMemoryDB();
            var table = database.GetTable(tableId);
            table.TableState=TableState.Active;
        }
    }
}
