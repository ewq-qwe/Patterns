using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.builder
{
    internal class CargoShipBuilder: IShipBuilder
    {
        private SpaceShip _ship = new SpaceShip();

        public void BuildHull() => _ship.Hull = "Легкий сплав зі збільшеним трюмом";
        public void BuildEngine() => _ship.Engine = "Економічний іонний двигун";
        public void BuildWeapon() => _ship.Weapon = "Відсутня";

        public SpaceShip GetShip() => _ship;
    }
}
