using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.abstract_factory
{
    internal class HumanEngine:IEngine
    {
        public void Start()=>Console.WriteLine("Ядерний двигун людей запущено. Швидкість: 100");
    }
}
