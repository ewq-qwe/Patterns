using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.decorator
{
    internal class Espresso : ICoffee
    {
        public double GetCost() => 30.0;
        public string GetDescription() => "Еспресо";
    }
}
