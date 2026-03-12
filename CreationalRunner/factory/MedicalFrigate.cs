using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.factory
{
    internal class MedicalFrigate:ISupportShip
    {
        public void PerformDuty() => Console.WriteLine("Медичний фрегат: Розгортаю польовий госпіталь на орбіті.");
    }
}
