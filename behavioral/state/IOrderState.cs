using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.state
{
    internal interface IOrderState
    {
        void Next(OrderContext context); 
        void Cancel();
    }
}
