using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.chainofresponsibility
{
    internal class ChatBot : SupportHandler
    {
        public override void Handle(string issueLevel)
        {
            if (issueLevel == "Simple") Console.WriteLine("Бот: Ваше замовлення вже в дорозі!");
            else Next?.Handle(issueLevel);
        }
    }
}
