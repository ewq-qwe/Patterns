using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.builder
{
    internal class SpaceShip
    {
        public string Hull { get; set; }
        public string Engine { get; set; }
        public string Weapon { get; set; }
        public void ShowSpecs()
        {
            Console.WriteLine($"Корабель готовий. Корпус: {Hull}, Двигун: {Engine}, Зброя: {Weapon}");
        }
    }
}
