using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge
{
    internal class RemoteControl
    {
        protected IDevice _device;
        public RemoteControl(IDevice device) => _device = device;

        public virtual void TogglePower() => _device.TurnOn();
        public virtual void VolumeUp() => _device.SetVolume(50);
    }
}
