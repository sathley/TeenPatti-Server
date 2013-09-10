using System.Collections.Generic;

namespace TeenPatti.Model
{
    public interface IVariationStrategy
    {
        CompareResult Compare(Hand A, Hand B, Dictionary<string, string> additionalInfo);
    }
}