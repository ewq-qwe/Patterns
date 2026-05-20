using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.OutputEncoding = System.Text.Encoding.UTF8;

namespace lab5
{
    internal class strategy
    {
        public class Program
        {
            public static int TotalAllValues(IEnumerable<int> values, Func<int, bool> selector)
            {
                return values.Where(selector).Sum();
            }

            public static bool IsOdd(int number) => number % 2 != 0;

            public static void Main()
            {
                var values = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

                Console.WriteLine("Сума всіх: " + TotalAllValues(values, n => true));
                Console.WriteLine("Сума парних: " + TotalAllValues(values, n => n % 2 == 0));
                Console.WriteLine("Сума непарних (через лямбду): " + TotalAllValues(values, n => n % 2 != 0));
                Console.WriteLine("Сума непарних (через метод): " + TotalAllValues(values, IsOdd));
            }
        }
    }
}

