using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.factory
{
    internal class CargoShip : IShip
    {
        public void Launch()
        {
            Console.WriteLine("Вантажний корабель важко відривається від платформи. Курс на Марс.");
        }
    }
}
