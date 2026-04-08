using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.composite
{
    internal interface IFileSystemComponent
    {
        int GetSize();
        void Display(int depth = 0);
    }
}
