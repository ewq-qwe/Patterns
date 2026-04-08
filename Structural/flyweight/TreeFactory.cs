using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.flyweight
{
    internal class TreeFactory
    {
        private static Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();
        public static TreeType GetTreeType(string name, string color, string texture)
        {
            if (!_treeTypes.ContainsKey(name))
            {
                _treeTypes[name] = new TreeType(name, color, texture);
                Console.WriteLine($"[Фабрика] Створено новий тип дерева: {name}");
            }
            return _treeTypes[name];
        }
    }
}
