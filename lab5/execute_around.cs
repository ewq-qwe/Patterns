using System;

namespace lab5
{
    public class Resource : IDisposable
    {
        private Resource()
        {
            Console.WriteLine("Створення зовнішнього ресурсу");
        }

        public static void Use(Action<Resource> block)
        {
            using (var resource = new Resource())
            {
                block(resource);
            }
        }

        public Resource Op1()
        {
            Console.WriteLine("Виконання операції 1");
            return this;
        }

        public Resource Op2()
        {
            Console.WriteLine("Виконання операції 2");
            return this;
        }

        public void Dispose()
        {
            Console.WriteLine("Очищення зовнішнього ресурсу");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Resource.Use(resource => resource.Op1().Op2());
        }
    }
}