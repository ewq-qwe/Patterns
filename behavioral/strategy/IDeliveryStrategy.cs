using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.strategy
{
    internal interface IDeliveryStrategy
    {
        double CalculateCost(double distance);
    }
}
