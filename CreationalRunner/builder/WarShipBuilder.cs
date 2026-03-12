using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.builder
{
    internal class WarShipBuilder : IShipBuilder
    {
        private SpaceShip _ship = new SpaceShip();

        public void BuildHull() => _ship.Hull = "Титанова броня";
        public void BuildEngine() => _ship.Engine = "Плазмовий рушій";
        public void BuildWeapon() => _ship.Weapon = "Лазерні гармати";
        public SpaceShip GetShip() => _ship;
    }
}
