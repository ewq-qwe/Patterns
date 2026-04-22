using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.memento
{
    internal class CartSnapshot
    {
        public List<string> Items { get; }
        public CartSnapshot(List<string> items) => Items = new List<string>(items);
    }
}
