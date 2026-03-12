using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.prototype
{
    internal class SwarmDrone : ISpaceDrone
    {
        public string ModelName { get; set; }
        public int LaserPower { get; set; }
        public string CombatAI { get; set; }
        public SwarmDrone(string model, int power, string ai)
        {
            Console.WriteLine($"[Завод]: Починаю складну збірку та прошивку оригінального дрона {model}...");
            ModelName = model;
            LaserPower = power;
            CombatAI = ai;
            Console.WriteLine($"[Завод]: Оригінал {model} готовий!");
            Console.WriteLine();
        }
        public ISpaceDrone Clone()
        {
            return (ISpaceDrone)this.MemberwiseClone();
        }
        public void ShowInfo()
        {
            Console.WriteLine($"- Дрон [{ModelName}] | Лазер: {LaserPower} | AI: {CombatAI}");
        }
    }
}
