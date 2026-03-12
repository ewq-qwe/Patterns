using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.factory
{
    internal class SupportShipFactory
    {
        public static ISupportShip CreateShip(SupportShipType type)
        {
            switch(type)
            {
                case SupportShipType.Miner:
                    return new MiningShip();

                case SupportShipType.Medical:
                    return new MedicalFrigate();

                case SupportShipType.Diplomatic:
                    return new DiplomaticCruiser();

                default:
                    throw new ArgumentException("Невідомий тип допоміжного корабля");
            }
        }
    }
}
