using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge
{
    internal interface IDevice
    {
        void TurnOn();
        void SetVolume(int percent);
    }
}
