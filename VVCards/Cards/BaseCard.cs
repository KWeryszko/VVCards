using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVCards.Cards
{
    internal abstract class BaseCard
    {
        public abstract override string ToString();
        protected int iSuit, iValue;
    }
}
