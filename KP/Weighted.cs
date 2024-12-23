﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public class Weighted : Product
    {
        public override double CostPerAmountOfUnits { get; set; }

        public Weighted(string id, string name, int amount, double cost, double price, DateTime lastDelivery, double costPerAmountOfUnits)
            : base(id, name, amount, cost, price, lastDelivery)
        {

            CostPerAmountOfUnits = costPerAmountOfUnits;
        }

        public Weighted() { }

        public override string GetUnit()
        {
            return "Грам";
        }

        public override double CalculateTotalValue()
        {
            return (Amount / CostPerAmountOfUnits) * Cost;
        }

        public override bool NeedsDiscount(DateTime currentDate)
        {
            return base.NeedsDiscount(currentDate) && CostPerAmountOfUnits > 1000;  // Уцінка, якщо продукт великий за вагою
        }
    }
}
