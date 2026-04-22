using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.observer
{
    internal class MobileAppCustomer : ISubscriber
    {
        private string _userName;
        public MobileAppCustomer(string name) => _userName = name;
        public void Update(string status) => Console.WriteLine($"Push для {_userName}: Замовлення тепер '{status}'");
    }
}
