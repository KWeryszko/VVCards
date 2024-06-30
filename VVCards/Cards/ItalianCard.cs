using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVCards.Suits.ItalianSuits;
using VVCards.Values.ItalianValues;

namespace VVCards.Cards
{
    internal class ItalianCard : BaseCard
    {
        public ItalianCard(int suit = 0, int value = 0)
        {
            eSuit = (ItalianSuits)suit;
            iSuit = suit;
            eValue = (ItalianValues)value;
            iValue = value;
        }
        public override string ToString()
        {
            return "Suit: " + eSuit + ", Value: " + eValue;
        }
        private ItalianSuits eSuit { get; set; }
        private ItalianValues eValue { get; set; }
    }
}
