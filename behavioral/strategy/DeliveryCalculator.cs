using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.strategy
{
    internal class DeliveryCalculator
    {
        private IDeliveryStrategy _strategy;
        public DeliveryCalculator(IDeliveryStrategy strategy) => _strategy = strategy;
        public void SetStrategy(IDeliveryStrategy strategy) => _strategy = strategy;

        public void PrintCost(double distance) =>
            Console.WriteLine($"Вартість доставки: {_strategy.CalculateCost(distance)} грн");
    }
}
