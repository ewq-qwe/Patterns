using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.adapter
{
    internal interface ILocalPayment
    {
        void ProcessPayment(double amount);
    }
}
