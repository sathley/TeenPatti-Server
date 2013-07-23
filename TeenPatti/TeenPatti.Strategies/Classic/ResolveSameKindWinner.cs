using System.Collections.Generic;
using TeenPatti.Interfaces;
using TeenPatti.Model;
using TeenPatti.Strategies;

namespace TeenPatti.Strategies
{
    public static class ResolveSameKindWinner 
    {
        private static readonly Dictionary<HandKind, ICompareSameKindClassicStrategy> Strategies ;

        static ResolveSameKindWinner()
        {
            Strategies=new Dictionary<HandKind, ICompareSameKindClassicStrategy>
                {
                    {HandKind.HighCard, new HighCardCompareStrategy()},
                    {HandKind.Colour, new ColourCompareStrategy()},
                    {HandKind.Pair, new PairCompareStrategy()},
                    {HandKind.PureSequence, new PureSequenceCompareStrategy()},
                    {HandKind.Sequence, new SequenceCompareStrategy()},
                    {HandKind.Trail, new TrailCompareStrategy()}
                };
        }

        public static CompareResult Compare(HandKind kind, Hand handA, Hand handB)
        {
            return Strategies[kind].Compare(handA, handB);
        }
       
    }
}