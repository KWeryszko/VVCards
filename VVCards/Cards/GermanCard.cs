using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVCards.Suits.GermanSuits;
using VVCards.Values.GermanValues;

namespace VVCards.Cards
{
    internal class GermanCard : BaseCard
    {
        public GermanCard(int suit = 0, int value = 0)
        {
            eSuit = (GermanSuits)suit;
            iSuit = suit;
            eValue = (GermanValues)value;
            iValue = value;
        }
        public override string ToString()
        {
            return "Suit: " + eSuit + ", Value: " + eValue;
        }
        private GermanSuits eSuit { get; set; }
        private GermanValues eValue { get; set; }
    }
}
