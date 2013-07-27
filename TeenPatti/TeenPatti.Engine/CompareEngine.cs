using System.Collections.Generic;
using TeenPatti.Interfaces;
using TeenPatti.Model;
using TeenPatti.Strategies;

namespace TeenPatti.Engine
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

        public static CompareResult Compare(VariationType variation, Hand A, Hand B, Dictionary<string,string> additionalInfo )
        {
            return Strategies[variation].Compare(A, B, additionalInfo);
        }

    }
}