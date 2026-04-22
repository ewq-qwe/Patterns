using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.memento
{
    internal class ShoppingCart
    {
        private List<string> _items = new();
        public void Add(string item) => _items.Add(item);
        public void Clear() => _items.Clear();
        public void Print() => Console.WriteLine("В кошику: " + string.Join(", ", _items));

        public CartSnapshot Save() => new CartSnapshot(_items);
        public void Restore(CartSnapshot snapshot) => _items = snapshot.Items;
    }
}
