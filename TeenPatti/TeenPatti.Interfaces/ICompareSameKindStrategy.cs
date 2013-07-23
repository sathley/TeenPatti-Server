using TeenPatti.Model;

namespace TeenPatti.Interfaces
{
    public interface ICompareSameKindClassicStrategy
    {
        CompareResult Compare(Hand handA, Hand handB);
    }


    public class HighCardCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            throw new System.NotImplementedException();
        }
    }

    public class PairCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            throw new System.NotImplementedException();
        }
    }

    public class SequenceCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            throw new System.NotImplementedException();
        }
    }

    public class PureSequenceCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ColourCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            throw new System.NotImplementedException();
        }
    }

    public class TrailCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            throw new System.NotImplementedException();
        }
    }
}