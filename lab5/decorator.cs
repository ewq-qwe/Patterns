using System;
using System.Linq;

Console.OutputEncoding = System.Text.Encoding.UTF8;

namespace lab5
{
    public class Camera
    {
        private readonly Func<string, string> _filter;

        public Camera(params Func<string, string>[] filters)
        {
            if (filters == null || filters.Length == 0)
            {
                _filter = input => input;
            }
            else
            {
                _filter = filters.Aggregate((f1, f2) => input => f2(f1(input)));
            }
        }

        public string Snap(string input)
        {
            return _filter(input);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Func<string, string> brighter = c => c + " (Зроблено світлішим)";
            Func<string, string> darker = c => c + " (Зроблено темнішим)";

            var plainCamera = new Camera();
            var brightCamera = new Camera(brighter);
            var mixedCamera = new Camera(darker, brighter);

            Console.WriteLine(plainCamera.Snap("Колір 125,125,125"));
            Console.WriteLine(brightCamera.Snap("Колір 125,125,125"));
            Console.WriteLine(mixedCamera.Snap("Колір 125,125,125"));
        }
    }
}