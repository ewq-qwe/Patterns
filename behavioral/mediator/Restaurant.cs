using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.mediator
{
    internal class Restaurant
    {
        private IDispatcher _dispatcher;
        public Restaurant(IDispatcher dispatcher) => _dispatcher = dispatcher;
        public void FoodReady() => _dispatcher.Notify(this, "FOOD_READY");
    }
}
