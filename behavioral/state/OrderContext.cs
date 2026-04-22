using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.state
{
    internal class OrderContext
    {
        private IOrderState _state;
        public OrderContext() => _state = new NewOrderState();
        public void SetState(IOrderState state) => _state = state;
        public void MoveNext() => _state.Next(this);
        public void CancelOrder() => _state.Cancel();
    }
}
