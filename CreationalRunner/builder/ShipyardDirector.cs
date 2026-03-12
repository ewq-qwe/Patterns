using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.builder
{
    internal class ShipyardDirector
    {
        private IShipBuilder _builder;

        public ShipyardDirector(IShipBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructFullShip()
        {
            _builder.BuildHull();
            _builder.BuildEngine();
            _builder.BuildWeapon();
        }
    }
}
