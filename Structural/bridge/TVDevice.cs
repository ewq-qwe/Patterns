using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge
{
    internal class TVDevice:IDevice
    {
        public void TurnOn() => Console.WriteLine("Телевізор увімкнено.");
        public void SetVolume(int percent) => Console.WriteLine($"Гучність ТБ: {percent}%");
    }
}
