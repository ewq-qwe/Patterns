using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.decorator
{
    internal class Milk : CoffeeDecorator
    {
        public Milk(ICoffee coffee) : base(coffee) { }
        public override double GetCost() => base.GetCost() + 10.0;
        public override string GetDescription() => base.GetDescription() + ", молоко";
    }
}
