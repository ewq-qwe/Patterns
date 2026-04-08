using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.adapter
{
    internal class StripeAdapter:ILocalPayment
    {
        private readonly Stripe _stripe = new Stripe();
        public void ProcessPayment(double amount)
        {
            double convertamount = amount / 43.91;
            _stripe.MakeTransaction(Math.Round(convertamount, 2), "USD");
        }
    }
}
