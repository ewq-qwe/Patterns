using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.bridge
{
    internal class AdvancedRemoteControl:RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }
        public void Mute() => _device.SetVolume(0);
    }
}
