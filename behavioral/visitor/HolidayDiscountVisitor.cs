using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.visitor
{
    internal class HolidayDiscountVisitor : IVisitor
    {
        public void Visit(PizzaItem pizza) => Console.WriteLine($"Піца зі знижкою: {pizza.Price * 0.8} грн");
        public void Visit(DrinkItem drink) => Console.WriteLine($"Напій зі знижкою: {drink.Price * 0.5} грн");
    }
}
