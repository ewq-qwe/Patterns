using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

 class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 12, 3, 8, 15, 8, 20, 1, 10 };
            List<double> doubles = new List<double> { 2.5, 4.0, 1.5, 6.0 };
            List<string> strings = new List<string> { "Banana", "Apple", "cherry", "", "Date", "blueberry" };
            List<string> capStrings = new List<string> { "Kyiv", "Lviv", "Chernivtsi" };
            string sentence = "How are you today?";

            Console.WriteLine("1. Непарні числа: " + string.Join(", ", FilterOddNumbers(numbers)));
            Console.WriteLine("2. Середнє значення: " + FindAverage(doubles));
            Console.WriteLine("3. Відсортовані рядки (алфавіт): " + string.Join(", ", SortAlphabetically(strings)));
            Console.WriteLine("4. Сума парних чисел: " + SumOfEvenNumbers(numbers));
            Console.WriteLine("5. Факторіал 5: " + CalculateFactorial(5));

            var (sum, product) = CalculateSumAndProduct(numbers);
            Console.WriteLine($"6. Сума елементів: {sum}, Добуток: {product}");

            Console.WriteLine("7. Квадрати чисел: " + string.Join(", ", CalculateSquares(numbers)));
            Console.WriteLine("8. Рядки за довжиною: " + string.Join(", ", SortByLength(strings)));
            Console.WriteLine("9. Кількість слів у реченні: " + CountWords(sentence));
            Console.WriteLine("10. Перший непорожній рядок: " + FindFirstNonEmpty(strings));
            Console.WriteLine("11. Всі починаються з великої літери (strings)? " + AreAllCapitalized(strings));
            Console.WriteLine("11. Всі починаються з великої літери (capStrings)? " + AreAllCapitalized(capStrings));
            Console.WriteLine("12. Друге за величиною число: " + FindSecondLargest(numbers));
            Console.WriteLine("13. Найбільше парне число: " + FindLargestEven(numbers));
        }

        // 1. Відфільтрувати непарні числа
        public static List<int> FilterOddNumbers(List<int> list)
        {
            return list.Where(n => n % 2 != 0).ToList();
        }

        // 2. Знайти середнє зі списку дійсних значень
        public static double FindAverage(List<double> list)
        {
            return list.Any() ? list.Average() : 0.0;
        }

        // 3. Сортування списку рядків в алфавітному порядку
        public static List<string> SortAlphabetically(List<string> list)
        {
            return list.OrderBy(s => s, StringComparer.OrdinalIgnoreCase).ToList();
        }

        // 4. Обчислення суми всіх парних чисел
        public static int SumOfEvenNumbers(List<int> list)
        {
            return list.Where(n => n % 2 == 0).Sum();
        }

        // 5. Обчислити факторіал заданого числа
        public static long CalculateFactorial(int n)
        {
            if (n < 0) throw new ArgumentException("Факторіал від'ємного числа не існує");
            if (n == 0) return 1;

            // Генеруємо послідовність від 1 до n і перемножуємо елементи
            return Enumerable.Range(1, n).Aggregate(1L, (acc, val) => acc * val);
        }

        // 6. Розрахувати множення та підсумовування всіх елементів
        public static (long Sum, long Product) CalculateSumAndProduct(List<int> list)
        {
            if (!list.Any()) return (0, 0);
            long sum = list.Sum(n => (long)n);
            long product = list.Aggregate(1L, (acc, val) => acc * val);
            return (sum, product);
        }

        // 7. Розрахувати квадрат кожного числа
            public static List<int> CalculateSquares(List<int> list)
            {
                return list.Select(n => n * n).ToList();
        }

        // 8. Сортування рядків на основі їх довжини в порядку зростання
        public static List<string> SortByLength(List<string> list)
        {
            return list.OrderBy(s => s.Length).ToList();
        }

        // 9. Підрахувати кількість слів у реченні
        public static int CountWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return 0;
            return sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count();
        }

        // 10. Знайти перший непорожній рядок
        public static string FindFirstNonEmpty(List<string> list)
        {
            return list.FirstOrDefault(s => !string.IsNullOrWhiteSpace(s)) ?? "Усі рядки порожні";
        }

        // 11. Перевірити, чи всі рядки починаються з великої літери
        public static bool AreAllCapitalized(List<string> list)
        {
            return list.Where(s => !string.IsNullOrEmpty(s))
                       .All(s => char.IsUpper(s[0]));
        }

        // 12. Знайти друге за величиною число
        public static int? FindSecondLargest(List<int> list)
        {
            var result = list.Distinct()
                             .OrderByDescending(n => n)
                             .Skip(1)
                             .Cast<int?>()
                             .FirstOrDefault();
            return result;
        }

        // 13. Знайти найбільше парне число
        public static int? FindLargestEven(List<int> list)
        {
            var evenNumbers = list.Where(n => n % 2 == 0).ToList();
            return evenNumbers.Any() ? evenNumbers.Max() : (int?)null;
        }
    }
