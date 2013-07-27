namespace TeenPatti.Model
{
    //  Table Boss
    public class TableManager
    {
        public Table Table { get; set; }

        public bool IsTableActive { get; set; }

        private Variation Variation { get; set; }

        public TableManager(Table table)
        {
            this.Table = table;
            this.IsTableActive = false;
        }

        public bool MayISit(long playerId)
        {
            if (Table.Players.Count >= Table.Capacity)
                return false;

            var player = Player.Get(playerId);

            if (player == null)
                return false;

            if (player.Bank < Table.MinimumBankRequired)
                return false;

            Table.Players.Add(player);

            return true;
        }


    }

    public enum TableState
    {
        Waiting,
        Active
    }

    public enum GameState
    {
        GameOver,
        GameStarted
    }

}