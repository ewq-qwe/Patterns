using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.iterator
{
    internal class MenuCollection : IEnumerable<string>
    {
        private List<string> _menuItems = new() { "Піца", "Суші", "Бургер" };

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in _menuItems)
            {
                yield return item;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
