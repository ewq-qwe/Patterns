using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.observer
{
    internal interface ISubscriber
    {
        void Update(string status);
    }
}
