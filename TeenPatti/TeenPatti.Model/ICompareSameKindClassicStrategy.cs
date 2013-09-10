namespace TeenPatti.Model
{
    public interface ICompareSameKindClassicStrategy
    {
        CompareResult Compare(Hand handA, Hand handB);
    }
}