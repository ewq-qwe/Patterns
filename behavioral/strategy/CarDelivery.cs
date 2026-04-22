using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.strategy
{
    internal class CarDelivery : IDeliveryStrategy
    {
        public double CalculateCost(double distance) => distance * 3.0 + 50;
    }
}
