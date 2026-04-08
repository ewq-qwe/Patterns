using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.adapter
{
    internal class LiqPay: ILocalPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Оплата {amount} грн через LiqPay пройшла успішно.");
        }
    }
}
