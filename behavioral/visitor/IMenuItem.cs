using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.visitor
{
    internal interface IMenuItem
    {
        void Accept(IVisitor visitor);
    }
}
