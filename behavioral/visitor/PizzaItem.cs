using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.visitor
{
    internal class PizzaItem : IMenuItem
    {
        public double Price = 200;
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
