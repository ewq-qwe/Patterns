using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge
{
    internal class RadioDevice:IDevice
    {
        public void TurnOn() => Console.WriteLine("Радіо увімкнено.");
        public void SetVolume(int percent) => Console.WriteLine($"Гучність Радіо: {percent}%");
    }
}
