using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.factory
{
    internal class FighterShipyard:Shipyard
    {
        protected override IShip CreateShip()
        {
            return new FighterShip();
        }
    }
}
