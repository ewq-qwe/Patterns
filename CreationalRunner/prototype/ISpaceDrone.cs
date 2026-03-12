using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.prototype
{
    internal interface ISpaceDrone
    {
        ISpaceDrone Clone();
        void ShowInfo();
    }
}
