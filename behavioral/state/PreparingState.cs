using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.state
{
    internal class PreparingState : IOrderState
    {
        public void Next(OrderContext context) => Console.WriteLine("Страва готова. Чекаємо кур'єра.");
        public void Cancel() => Console.WriteLine("Неможливо скасувати! Кухар вже витратив продукти.");
    }
}
