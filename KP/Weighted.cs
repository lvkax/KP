using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public class Weighted : Product
    {
        public double WeightPerUnit { get; set; }

        public Weighted(string id, string name, double cost, int amount, DateTime lastDelivery, double costPer100gram, double weightPerUnit )
            : base(id, name, cost, amount, lastDelivery )
        {

            WeightPerUnit = weightPerUnit;
        }

        public override string GetUnit()
        {
            return "грам";
        }

        public override bool NeedsDiscount(DateTime currentDate)
        {
            return base.NeedsDiscount(currentDate) && WeightPerUnit > 5000;  // Уцінка, якщо продукт великий за вагою
        }
    }
}
