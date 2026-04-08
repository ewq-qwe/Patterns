using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.facade
{
    internal class Player
    {
        public void Play(string movie)
        {
            Console.WriteLine($"Фільм '{movie}' запущено.");
        }
    }
}
