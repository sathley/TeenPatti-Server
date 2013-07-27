using System.Collections.Generic;
using TeenPatti.Model;

namespace TeenPatti.Interfaces
{
    public interface IVariationStrategy
    {
        CompareResult Compare(Hand A, Hand B, Dictionary<string, string> additionalInfo);
    }
}