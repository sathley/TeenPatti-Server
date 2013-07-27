using System.Collections.Generic;

namespace TeenPatti.Server
{
    public interface IVariationStrategy
    {
        CompareResult Compare(Hand A, Hand B, Dictionary<string, string> additionalInfo);
    }
}