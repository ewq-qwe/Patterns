using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.mediator
{
    internal class DeliveryDispatcher : IDispatcher
    {
        private Courier _courier = new();
        public void Notify(object sender, string eventCode)
        {
            if (eventCode == "FOOD_READY")
            {
                Console.WriteLine("Диспетчер: Страва готова, шукаю кур'єра...");
                _courier.GoToRestaurant();
            }
        }
    }
}
