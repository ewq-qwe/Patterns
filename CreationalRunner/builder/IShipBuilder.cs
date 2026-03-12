using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.builder
{
    internal interface IShipBuilder
    {
        void BuildHull();
        void BuildEngine();
        void BuildWeapon();
        SpaceShip GetShip();
    }
}
