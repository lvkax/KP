﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public class Weighted : Product
    {
        public double CostPerAmountOfUnits { get; set; }

        public Weighted(string id, string name, double cost, int amount, DateTime lastDelivery, double costPer100gram, double costPerAmountOfUnits )
            : base(id, name, cost, amount, lastDelivery )
        {

            CostPerAmountOfUnits = costPerAmountOfUnits;
        }

        public override string GetUnit()
        {
            return "Грам";
        }

        public override double CalculateTotalValue()
        {
            return Cost / CostPerAmountOfUnits * Amount;
        }

        public override bool NeedsDiscount(DateTime currentDate)
        {
            return base.NeedsDiscount(currentDate) && CostPerAmountOfUnits > 1000;  // Уцінка, якщо продукт великий за вагою
        }
    }
}
