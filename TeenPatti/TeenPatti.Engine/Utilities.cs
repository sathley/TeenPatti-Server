using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeenPatti.Model;

namespace TeenPatti.Engine
{
    public static class Utilities
    {
        public static List<Card> MakeAcesValueFourteen(List<Card> cards)
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
