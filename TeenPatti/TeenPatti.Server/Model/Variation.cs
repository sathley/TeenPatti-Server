namespace TeenPatti.Server
{
    public class Variation
    {
        public long Id { get; set; }

        public VariationType VariationType { get; set; }

        public VariationType GetVariationType()
        {
            return this.VariationType;
        }

        public Variation(VariationType variationType)
        {
            this.VariationType = variationType;
        }
    }
}