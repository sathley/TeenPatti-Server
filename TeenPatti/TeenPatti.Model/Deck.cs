using System;

namespace TeenPatti.Model
{
    public class Deck
    {
        private Card[] _cards = new Card[52];
        private Random _random;
        public Deck()
        {
            this._cards = new Card[52];
            this._random = new Random();
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 13; j++)
                {
                    _cards[(j) + (13*i)] = new Card(j+1, (Suit)i);
                }
            }
            Shuffle();
        }

        private void Shuffle()
        {
            for (int i = _cards.Length - 1; i > 0; i--)
            {
                int n = _random.Next(i + 1);
                Swap(ref _cards[i], ref _cards[n]);
            }
        }

        private void Swap(ref Card cardOne, ref Card cardTwo)
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
            if (_cards.Length <= 0) 
                return null;
            var returnCard = _cards[_cards.Length - 1];
            _cards[_cards.Length - 1] = null;
            return returnCard;
        }
    }
}