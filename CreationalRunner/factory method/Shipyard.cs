using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.factory
{
    public abstract class Shipyard
    {
        protected abstract IShip CreateShip();
        public void DispatchShip()
        {
            Console.WriteLine("Верф: Починаю передпольотну підготовку...");

            IShip ship = CreateShip();

            Console.WriteLine("Верф: Підготовка завершена. Даю дозвіл на зліт.");
            ship.Launch();
        }
    }
}
