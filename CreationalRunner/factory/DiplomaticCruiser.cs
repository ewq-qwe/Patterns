using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.factory
{
    internal class DiplomaticCruiser : ISupportShip
    {
        public void PerformDuty() => Console.WriteLine("Дипломатичне судно: Відправляю мирні канали зв'язку.");
    }
}
