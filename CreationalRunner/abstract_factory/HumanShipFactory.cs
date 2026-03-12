using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.abstract_factory
{
    internal class HumanShipFactory:ISpaceShipFactory
    {
        public IEngine CreateEngine() => new HumanEngine();
        public IHull CreateHull() => new HumanHull();
    }
}
