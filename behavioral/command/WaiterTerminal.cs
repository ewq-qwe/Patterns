using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.command
{
    internal class WaiterTerminal
    {
        private Queue<IOrderCommand> _orders = new();
        public void TakeOrder(IOrderCommand command) => _orders.Enqueue(command);
        public void SendToKitchen()
        {
            while (_orders.Count > 0) _orders.Dequeue().Execute();
        }
    }
}
