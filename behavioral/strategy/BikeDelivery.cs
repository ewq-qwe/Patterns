using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.strategy
{
    internal class BikeDelivery : IDeliveryStrategy
    {
        public double CalculateCost(double distance) => distance * 1.5;
    }
}
