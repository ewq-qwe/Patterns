using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.factory
{
    internal class MiningShip : ISupportShip
    {
        public void PerformDuty() => Console.WriteLine("Шахтарський корабель: Починаю буріння астероїда...");
    }
}
