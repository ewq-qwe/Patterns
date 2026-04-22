using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioral.templatmethod
{
    internal abstract class HotBeverageMaker
    {
        public void MakeBeverage() { BoilWater(); Brew(); PourInCup(); AddCondiments(); }

        private void BoilWater() => Console.WriteLine("Кип'ятимо воду...");
        private void PourInCup() => Console.WriteLine("Наливаємо у фірмову чашку.");

        protected abstract void Brew();
        protected abstract void AddCondiments();
    }
}
