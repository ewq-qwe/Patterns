using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.facade
{
    internal class Audio
    {
        public void SetVolume(int level)
        {
            Console.WriteLine($"Гучність встановлено на {level}."); 
        }
    }
}
