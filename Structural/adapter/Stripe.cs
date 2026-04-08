using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.adapter
{
    internal class Stripe
    {
        public void MakeTransaction(double value,string currency)
        {
            Console.WriteLine($"Транзакція на суму {value} {currency} успішна через Stripe.");
        }
    }
}
