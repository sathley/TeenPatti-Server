using System.Collections.Generic;
using TeenPatti.Interfaces;
using TeenPatti.Model;
using TeenPatti.Strategies;

namespace TeenPatti.Engine
{
    public static class CompareEngine
    {
        public static readonly Dictionary<Variation, IVariationStrategy> Strategies;

        static CompareEngine()
        {
            Strategies=new Dictionary<Variation, IVariationStrategy>
                {
                    {Variation.Classic, new ClassicStrategy()},
                    {Variation.AK47, new AK47VariationStrategy()},
                    {Variation.Discard1, new Discard1VariationStrategy()},
                    {Variation.Imagine1, new Imagine1VariationStrategy()},
                    {Variation.Mufflis, new MufflisVariationStrategy()}
                };
        }

        public static CompareResult Compare(Variation variation, Hand A, Hand B, Dictionary<string,string> additionalInfo )
        {
            return Strategies[variation].Compare(A, B, additionalInfo);
        }

    }
}