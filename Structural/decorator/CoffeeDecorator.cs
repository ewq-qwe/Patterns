using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.decorator
{
    internal class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;
        public CoffeeDecorator(ICoffee coffee) => _coffee = coffee;

        public virtual double GetCost() => _coffee.GetCost();
        public virtual string GetDescription() => _coffee.GetDescription();
    }
}
