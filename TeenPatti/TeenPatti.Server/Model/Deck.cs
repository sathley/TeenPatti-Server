using System;
using System.Collections.Generic;
using System.Linq;

namespace TeenPatti.Server
{
    public class Deck
    {
        private Card[] _cards = new Card[52];

        public Deck()
        {
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 13; j++)
                {
                    _cards[(j) + (13*i)] = new Card(j+1, (Suit)i);
                }
            }
            Shuffle(ref _cards);
        }

        private static void Shuffle(ref Card[] cards)
        {
            var rand = new Random();
            for (int i = cards.Length - 1; i > 0; i--)
            {
                int n = rand.Next(i + 1);
                Swap(ref cards[i], ref cards[n]);
            }
        }

        private static void Swap(ref Card cardOne, ref Card cardTwo)
        {
            var tempSuite = cardOne.Suite;
            var tempValue = cardOne.Value;

            cardOne.SetSuite(cardTwo.Suite);
            cardOne.SetValue(cardTwo.Value);

            cardTwo.SetSuite(tempSuite);
            cardTwo.SetValue(tempValue);
        }

        public Card Deal()
        {
            var cardsList = new List<Card>(_cards);
            if (cardsList.Count <= 0) 
                return null;
            var returnCard = cardsList.ElementAt(cardsList.Count-1);
            cardsList.RemoveAt(cardsList.Count-1);
            _cards = cardsList.ToArray();
            return returnCard;
        }
    }
}