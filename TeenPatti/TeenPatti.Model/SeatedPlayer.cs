namespace TeenPatti.Model
{
    public class SeatedPlayer
    {
        public Player Player { get; set; }

        public bool IsActive { get; set; }

        public bool IsSeen { get; set; }

        public long BankOnTable { get; set; }
    }
}