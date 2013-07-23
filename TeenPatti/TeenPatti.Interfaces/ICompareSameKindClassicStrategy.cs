using TeenPatti.Model;

namespace TeenPatti.Interfaces
{
    public interface ICompareSameKindClassicStrategy
    {
        CompareResult Compare(Hand handA, Hand handB);
    }
}