namespace TeenPatti.Server
{
    public interface ICompareSameKindClassicStrategy
    {
        CompareResult Compare(Hand handA, Hand handB);
    }
}