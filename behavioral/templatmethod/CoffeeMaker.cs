using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.templatmethod
{
    internal class CoffeeMaker : HotBeverageMaker
    {
        protected override void Brew() => Console.WriteLine("Заварюємо еспресо.");
        protected override void AddCondiments() => Console.WriteLine("Додаємо молоко і сироп.");
    }
}
