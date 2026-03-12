using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.abstract_factory
{
    internal class AlienShipFactory:ISpaceShipFactory
    {
        public IEngine CreateEngine() => new AlienEngine();
        public IHull CreateHull() => new AlienHull();
    }
}
