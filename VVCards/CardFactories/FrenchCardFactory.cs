using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVCards.Cards;
using VVCards.Suits.FrenchSuits;
using VVCards.Values.FrenchValues;

namespace VVCards.CardFactories
{
    internal sealed class FrenchCardFactory : BaseCardFactory
    {
        private FrenchCardFactory() { }
        public override BaseCardFactory getInstance()
        {
            if(_instance == null) {  _instance = new FrenchCardFactory(); }
            return _instance;
        }
        public override BaseCard CreateCard(int suit, int value)
        {
            return new FrenchCard(suit, value);
        }
        public  BaseCard[] CreateDeck()
        {
            throw new NotImplementedException();
        }
        public override BaseCard[] CreateFullDeck()
        {
            List<FrenchCard> deck = new(0);
            foreach (FrenchSuits suit in Enum.GetValues(typeof(FrenchSuits)))
            {
                foreach (FrenchValues value in Enum.GetValues(typeof(FrenchValues)))
                {
                    deck.Add(new FrenchCard((int)suit, (int)value));
                }
            }
            return deck.ToArray();
        }
    }
}
