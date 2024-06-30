using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVCards.Suits.FrenchSuits;
using VVCards.Values.FrenchValues;

namespace VVCards.Cards
{
    internal class FrenchCard : BaseCard
    {
        public FrenchCard(int suit=0, int value=0)
        {
            eSuit = (FrenchSuits)suit;
            iSuit = suit;
            eValue = (FrenchValues)value;
            iValue = value;  
        }
        public override string ToString()
        {
            return "Suit: " + eSuit + ", Value: " + eValue;
        }
        private FrenchSuits eSuit { get; set; }
        private FrenchValues eValue { get; set; }
    }
}
