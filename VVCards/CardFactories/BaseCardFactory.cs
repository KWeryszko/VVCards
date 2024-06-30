using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVCards.CardFactories
{
    internal abstract class BaseCardFactory
    {
        public abstract Cards.BaseCard CreateCard(int suit, int value);
        public abstract Cards.BaseCard[] CreateFullDeck();
        public abstract BaseCardFactory getInstance();
        protected BaseCardFactory _instance;
        
    }
}
