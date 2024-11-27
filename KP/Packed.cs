using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public class Packed : Product
    {
        public override string PackSize { get; set; } = "N/A";

        public Packed(string id, string name, double cost, double price, int amount, DateTime lastDelivery, string packSize)
            : base(id, name, cost, price, amount, lastDelivery)
        {
            PackSize = packSize;
        }

        public Packed()
        { }

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
