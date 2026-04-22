using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.state
{
    internal class NewOrderState : IOrderState
    {
        public void Next(OrderContext context)
        {
            Console.WriteLine("Замовлення оплачено. Передаємо на кухню.");
            context.SetState(new PreparingState());
        }
        public void Cancel() => Console.WriteLine("Замовлення скасовано клієнтом без штрафу.");
    }
}
