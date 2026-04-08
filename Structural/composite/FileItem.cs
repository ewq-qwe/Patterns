using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.composite
{
    internal class FileItem : IFileSystemComponent
    {
        private string _name;
        private int _size;

        public FileItem(string name, int size) { _name = name; _size = size; }
        public int GetSize() => _size;
        public void Display(int depth = 0) => Console.WriteLine(new string('-', depth) + $" Файл: {_name} ({_size} KB)");
    }
}
