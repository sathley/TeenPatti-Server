using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeenPatti.Model;

namespace TeenPatti.Tests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void ShuffleDeckTestFixture()
        {
            var deck = new Deck();
            while (true)
            {
                var card = deck.Deal();
                if(card==null)
                    break;
                System.Diagnostics.Debug.WriteLine(card.ToString());
            }
        }
    }
}
