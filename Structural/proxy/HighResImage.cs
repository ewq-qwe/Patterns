using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.proxy
{
    internal class HighResImage : IImage
    {
        private string _filename;
        public HighResImage(string filename)
        {
            _filename = filename;
        }
        public void Display()
        {
            Console.WriteLine($"Відображення {_filename}");
        }
    }
}
