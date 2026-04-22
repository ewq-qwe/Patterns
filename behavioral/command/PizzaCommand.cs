using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.command
{
    internal class PizzaCommand : IOrderCommand
    {
        private Chef _chef;
        public PizzaCommand(Chef chef) => _chef = chef;
        public void Execute() => _chef.CookPizza();
    }
}
