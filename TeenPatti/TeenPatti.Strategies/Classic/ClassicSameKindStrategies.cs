 using System;
 using System.Linq;
 using TeenPatti.Interfaces;
using TeenPatti.Model;

namespace TeenPatti.Strategies
{
    public class HighCardCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            var cardsA = Utilities.MakeAceValuesFourteen(handA.Cards);
            var cardsB = Utilities.MakeAceValuesFourteen(handB.Cards);
            
            //  Check highest card
            var maxA = Math.Max(Math.Max(cardsA[0].Value, cardsA[1].Value), cardsA[2].Value);
            var maxB = Math.Max(Math.Max(cardsB[0].Value, cardsB[1].Value), cardsB[2].Value);
            
            if(maxA>maxB)   return CompareResult.AWon;
            if(maxB>maxA)   return CompareResult.BWon;

            cardsA.RemoveAll(c => c.Value.Equals(maxA));
            cardsB.RemoveAll(c => c.Value.Equals(maxB));

            //  Check second highest card
            maxA = Math.Max(cardsA[0].Value, cardsA[1].Value);
            maxB = Math.Max(cardsB[0].Value, cardsB[1].Value);
            
            if (maxA > maxB) return CompareResult.AWon;
            if (maxB > maxA) return CompareResult.BWon;

            cardsA.RemoveAll(c => c.Value.Equals(maxA));
            cardsB.RemoveAll(c => c.Value.Equals(maxB));

            //  Check last card
            maxA = cardsA[0].Value;
            maxB = cardsB[0].Value;
            
            if (maxA > maxB) return CompareResult.AWon;
            if (maxB > maxA) return CompareResult.BWon;

            return CompareResult.Draw;
        }
    }

    public class PairCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            var cardsA = Utilities.MakeAceValuesFourteen(handA.Cards);
            var cardsB = Utilities.MakeAceValuesFourteen(handB.Cards);

            //  Compare pairs
            int pairValA = cardsA[0].Value == cardsA[1].Value
                               ? cardsA[0].Value
                               : cardsA[1].Value == cardsA[2].Value ? cardsA[1].Value : cardsA[2].Value;
            int pairValB = cardsB[0].Value == cardsB[1].Value
                               ? cardsB[0].Value
                               : cardsB[1].Value == cardsB[2].Value ? cardsB[1].Value : cardsB[2].Value;

            if(pairValA>pairValB)   return CompareResult.AWon;
            if(pairValB>pairValA)   return CompareResult.BWon;

            //  If pairs are same
            var kickerA = cardsA[0].Value == cardsA[1].Value
                              ? cardsA[2].Value
                              : cardsA[1].Value == cardsA[2].Value ? cardsA[0].Value : cardsA[1].Value;

            var kickerB = cardsB[0].Value == cardsB[1].Value
                              ? cardsB[2].Value
                              : cardsB[1].Value == cardsB[2].Value ? cardsB[0].Value : cardsB[1].Value;

            if (kickerA>kickerB)    return CompareResult.AWon;
            if (kickerB>kickerA)    return CompareResult.BWon;

            //  If pairs and kickers are same
            return CompareResult.Draw;
            
        }
    }

    public class SequenceCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            var cardsA = Utilities.MakeAceValuesFourteen(handA.Cards);
            var cardsB = Utilities.MakeAceValuesFourteen(handB.Cards);

            int cardsSumA = cardsA.Sum(card => card.Value); 
            int cardsSumB = cardsB.Sum(card => card.Value);

            //  Because A-K-Q > A-2-3 > K-Q-J
            //  A+2+3 = 19 (can only be beaten by A-K-Q (sum=39))
            if(cardsSumA == 19 && cardsSumB != 39)  return CompareResult.AWon;
            if (cardsSumB == 19 && cardsSumA != 39) return CompareResult.BWon;

            if (cardsSumA>cardsSumB)    return CompareResult.AWon;
            if (cardsSumB>cardsSumA)    return CompareResult.BWon;
            
            return CompareResult.Draw;
        }
    }

    public class PureSequenceCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            var cardsA = Utilities.MakeAceValuesFourteen(handA.Cards);
            var cardsB = Utilities.MakeAceValuesFourteen(handB.Cards);

            int cardsSumA = cardsA.Sum(card => card.Value);
            int cardsSumB = cardsB.Sum(card => card.Value);

            //  Because A-K-Q > A-2-3 > K-Q-J
            //  A+2+3 = 19 (can only be beaten by A-K-Q (sum=39))
            if (cardsSumA == 19 && cardsSumB != 39) return CompareResult.AWon;
            if (cardsSumB == 19 && cardsSumA != 39) return CompareResult.BWon;

            if (cardsSumA > cardsSumB) return CompareResult.AWon;
            if (cardsSumB > cardsSumA) return CompareResult.BWon;

            return CompareResult.Draw;
        }
    }

    public class ColourCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            var cardsA = Utilities.MakeAceValuesFourteen(handA.Cards);
            var cardsB = Utilities.MakeAceValuesFourteen(handB.Cards);

            //  Check highest card
            var maxA = Math.Max(Math.Max(cardsA[0].Value, cardsA[1].Value), cardsA[2].Value);
            var maxB = Math.Max(Math.Max(cardsB[0].Value, cardsB[1].Value), cardsB[2].Value);

            if (maxA > maxB) return CompareResult.AWon;
            if (maxB > maxA) return CompareResult.BWon;

            cardsA.RemoveAll(c => c.Value.Equals(maxA));
            cardsB.RemoveAll(c => c.Value.Equals(maxB));

            //  Check second highest card
            maxA = Math.Max(cardsA[0].Value, cardsA[1].Value);
            maxB = Math.Max(cardsB[0].Value, cardsB[1].Value);

            if (maxA > maxB) return CompareResult.AWon;
            if (maxB > maxA) return CompareResult.BWon;

            cardsA.RemoveAll(c => c.Value.Equals(maxA));
            cardsB.RemoveAll(c => c.Value.Equals(maxB));

            //  Check last card
            maxA = cardsA[0].Value;
            maxB = cardsB[0].Value;

            if (maxA > maxB) return CompareResult.AWon;
            if (maxB > maxA) return CompareResult.BWon;

            return CompareResult.Draw;
        }
    }

    public class TrailCompareStrategy : ICompareSameKindClassicStrategy
    {
        public CompareResult Compare(Hand handA, Hand handB)
        {
            var cardsA = Utilities.MakeAceValuesFourteen(handA.Cards);
            var cardsB = Utilities.MakeAceValuesFourteen(handB.Cards);

            if(cardsA[0].Value>cardsB[0].Value) return CompareResult.AWon;
            if(cardsB[0].Value>cardsA[0].Value) return CompareResult.BWon;

            return CompareResult.Draw;
        }
    }
}