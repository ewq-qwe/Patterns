using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.abstract_factory
{
    internal class AlienHull:IHull
    {
        public void ShowDurability() => Console.WriteLine("Корпус із біоматеріалу. Міцність: 5000");
    }
}
