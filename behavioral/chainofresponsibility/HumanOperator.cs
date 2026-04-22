using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace behavioral.chainofresponsibility
{
    internal class HumanOperator : SupportHandler
    {
        public override void Handle(string issueLevel)
        {
            if (issueLevel == "Complex") Console.WriteLine("Оператор: Зв'язуюсь із кур'єром для уточнення...");
            else Next?.Handle(issueLevel);
        }
    }
}
