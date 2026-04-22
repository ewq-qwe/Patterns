using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.visitor
{
    internal class DrinkItem : IMenuItem
    {
        public double Price = 50;
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
