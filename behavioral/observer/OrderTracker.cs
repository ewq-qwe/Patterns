using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.observer
{
    internal class OrderTracker
    {
        private List<ISubscriber> _subscribers = new();
        private string _status;

        public void Subscribe(ISubscriber sub) => _subscribers.Add(sub);
        public void ChangeStatus(string newStatus)
        {
            _status = newStatus;
            foreach (var sub in _subscribers) sub.Update(_status);
        }
    }
}
