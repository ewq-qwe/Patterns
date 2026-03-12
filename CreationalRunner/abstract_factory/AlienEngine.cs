using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.abstract_factory
{
    internal class AlienEngine:IEngine
    {
        public void Start() => Console.WriteLine("Гравітаційний рушій прибульців активовано.Швидкість: 500");
    }
}
