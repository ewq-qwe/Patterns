using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.composite
{
    internal class Folder : IFileSystemComponent
    {
        private string _name;
        private List<IFileSystemComponent> _components = new List<IFileSystemComponent>();

        public Folder(string name) => _name = name;
        public void Add(IFileSystemComponent component) => _components.Add(component);

        public int GetSize() => _components.Sum(c => c.GetSize());

        public void Display(int depth = 0)
        {
            Console.WriteLine(new string('-', depth) + $" Папка: {_name} (Загальний розмір: {GetSize()} KB)");
            foreach (var component in _components) component.Display(depth + 2);
        }
    }
}
