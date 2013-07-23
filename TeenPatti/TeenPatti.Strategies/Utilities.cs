using System.Collections.Generic;
using TeenPatti.Model;

namespace TeenPatti.Strategies
{
    public static class Utilities
    {
        public static List<Card> MakeAcesValuesFourteen(List<Card> cards)
        {
            var returnCards = new List<Card>();
            foreach (var card in cards)
            {
                if(card.Value == 1)
                    card.SetValue(14);
                returnCards.Add(card);
            }
            return returnCards;
        }
    }
}
