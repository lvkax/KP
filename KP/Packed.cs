using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public class Packed : Product
    {
       public int PackSize { get; set; } //Розмір упаковки

        public Packed(string id, string name, double cost, int amount, DateTime lastDelivery, int packSize)
            :base(id, name, cost, amount , lastDelivery )
        {
            PackSize = packSize;
        }

        public override string GetUnit()
        {
            return "Шт.";
        }

        public override double CalculateTotalValue()
        {
            return Cost * Amount;
        }

        public override bool NeedsDiscount(DateTime currentDate)
        {
            return base.NeedsDiscount(currentDate) && Amount < 50;  // Уцінка, якщо мало залишилось
        }
    }
}
