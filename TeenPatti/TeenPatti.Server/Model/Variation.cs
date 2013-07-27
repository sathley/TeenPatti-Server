namespace TeenPatti.Server
{
    public enum VariationType
    {
        Classic,
        AK47,
        AK56,
        JQ23,
        RedBlackMisfit,
        RPJ,
        Highest235,
        Mufflis,
        Imagine1,
        Discard1,
        Maththa
    }

    public class Variation
    {
        public VariationType VariationType { get; set; }

        public Variation(VariationType variationType)
        {
            this.VariationType = variationType;
            this.CardsPerPlayer = variationType.GetNumberOfCardsPerPlayer();
        }

        public int CardsPerPlayer { get; set; }
    }

    public static class VariationDetailsProvider
    {
        public static int GetNumberOfCardsPerPlayer(this VariationType variationType)
        {
            if (variationType == VariationType.Classic)
            {
                return 3;
            }
            return 3;
        }
    }
}