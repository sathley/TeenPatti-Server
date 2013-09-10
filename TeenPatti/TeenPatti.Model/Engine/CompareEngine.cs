using System.Collections.Generic;

namespace TeenPatti.Model
{
    public static class CompareEngine
    {
        public static readonly Dictionary<VariationType, IVariationStrategy> Strategies;

        static CompareEngine()
        {
            Strategies=new Dictionary<VariationType, IVariationStrategy>
                {
                    {VariationType.Classic, new ClassicStrategy()},
                    {VariationType.AK47, new AK47VariationStrategy()},
                    {VariationType.Discard1, new Discard1VariationStrategy()},
                    {VariationType.Imagine1, new Imagine1VariationStrategy()},
                    {VariationType.Mufflis, new MufflisVariationStrategy()}
                };
        }

        public static CompareResult Compare(VariationType variation, Hand a, Hand b, Dictionary<string,string> additionalInfo )
        {
            return Strategies[variation].Compare(a, b, additionalInfo);
        }

    }
}