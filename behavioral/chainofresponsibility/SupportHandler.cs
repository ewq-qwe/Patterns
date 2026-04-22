using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.chainofresponsibility
{
    internal abstract class SupportHandler
    {
        protected SupportHandler Next;
        public void SetNext(SupportHandler next) => Next = next;
        public abstract void Handle(string issueLevel);
    }
}
