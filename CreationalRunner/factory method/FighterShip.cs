using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.factory
{
    internal class FighterShip : IShip
    {
        public void Launch()
        {
            Console.WriteLine("Бойовий винищувач стрімко стартує! Системи зброї активовано.");
        }
    }
}
