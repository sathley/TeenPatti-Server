using System;
using System.Collections.Generic;
using System.Threading;

namespace TeenPatti.Model
{
    public class Table
    {
        public Table(VariationType variationType, int capacity, long boot, long minBankRequired, int minPlayersRequired, string channel)
        {
            this.VariationType = variationType;
            this.Capacity = capacity;
            this.BootValue = boot;
            this.MinimumBankRequired = minBankRequired;
            this.MinimumPlayersRequired = minPlayersRequired;
            this.TableState = TableState.Inactive;
            this.Channel = channel;
            this.CurrentStake = boot;
            this.CurrentPlayer = 0;
            this.SeatedPlayers = new SeatedPlayer[capacity];
        }

        public long Id { get; set; }

        public string Channel { get; private set; }

        public int Capacity { get; private set; }

        public long BootValue { get; private set; }

        public long CurrentStake { get; set; }

        public TableState TableState { get; private set; }

        public VariationType VariationType { get; private set; }

        public SeatedPlayer[] SeatedPlayers { get; private set; }

        public int CurrentPlayer { get; set; }

        public List<long> Audience { get; private set; }

        public long MinimumBankRequired { get; set; }

        public int MinimumPlayersRequired { get; set; }

        public static List<Table> GetAllTables()
        {
            //ITableDatabase tableDb = new InMemoryDB();
            throw new NotImplementedException();
        }

        public bool Sit(long playerId, int position, long bankOnTable)
        {
            //var player = Player.Get(playerId);

            //if (player == null || player.Bank < MinimumBankRequired)
            //    return false;

            //if (SeatedPlayers[position] != null)
            //    return false;

            //SeatedPlayers[position] = new SeatedPlayer()
            //    {
            //        Player = player,
            //        BankOnTable = 0,
            //        IsActive = false,
            //        IsSeen = false
            //    };
            return true;
        }

        public void LeaveTable(long playerId)
        {
            for (int i = 0; i < SeatedPlayers.Length; i++)
            {
                if (SeatedPlayers[i].Player.Id.Equals(playerId))
                {
                    SeatedPlayers[i] = null;
                    return;
                }

            }
        }

        public void InitGameplay()
        {
            while (true)
            {
                //  Wait for table to be ready
                if (this.TableState == TableState.Inactive && this.SeatedPlayers.Length < this.MinimumPlayersRequired)
                {
                    Thread.Sleep(3000);
                    continue;
                }
                //  Activate gameplay
                this.TableState = TableState.Active;

            }
        }

        private void WriteScoresToDb(long playerId, long val)
        {

        }
    }
}
