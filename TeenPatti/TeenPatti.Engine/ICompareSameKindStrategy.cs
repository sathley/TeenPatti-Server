using System.Collections.Generic;
using TeenPatti.Model;

namespace TeenPatti.Engine
{
    public interface ICompareSameKindStrategy
    {
        CompareResult Compare(ClassicHand handA, ClassicHand handB);
    }

    public static class ResolveSameKindWinner 
    {
        private static readonly Dictionary<HandKind, ICompareSameKindStrategy> Strategies ;

        static ResolveSameKindWinner()
        {
            Strategies=new Dictionary<HandKind, ICompareSameKindStrategy>
                {
                    {HandKind.HighCard, new HighCardCompareStrategy()},
                    {HandKind.Colour, new ColourCompareStrategy()},
                    {HandKind.Pair, new PairCompareStrategy()},
                    {HandKind.PureSequence, new PureSequenceCompareStrategy()},
                    {HandKind.Sequence, new SequenceCompareStrategy()},
                    {HandKind.Trail, new TrailCompareStrategy()}
                };
        }

        public static CompareResult Compare(HandKind kind, ClassicHand handA, ClassicHand handB)
        {
            return Strategies[kind].Compare(handA, handB);
        }
       
    }



    public class HighCardCompareStrategy : ICompareSameKindStrategy
    {
        public CompareResult Compare(ClassicHand handA, ClassicHand handB)
        {
            throw new System.NotImplementedException();
        }
    }

    public class PairCompareStrategy : ICompareSameKindStrategy
    {
        public CompareResult Compare(ClassicHand handA, ClassicHand handB)
        {
            throw new System.NotImplementedException();
        }
    }

    public class SequenceCompareStrategy : ICompareSameKindStrategy
    {
        public CompareResult Compare(ClassicHand handA, ClassicHand handB)
        {
            throw new System.NotImplementedException();
        }
    }

    public class PureSequenceCompareStrategy : ICompareSameKindStrategy
    {
        public CompareResult Compare(ClassicHand handA, ClassicHand handB)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ColourCompareStrategy : ICompareSameKindStrategy
    {
        public CompareResult Compare(ClassicHand handA, ClassicHand handB)
        {
            throw new System.NotImplementedException();
        }
    }

    public class TrailCompareStrategy : ICompareSameKindStrategy
    {
        public CompareResult Compare(ClassicHand handA, ClassicHand handB)
        {
            throw new System.NotImplementedException();
        }
    }
}