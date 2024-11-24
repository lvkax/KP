using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public abstract class Product
    {
        //Властивості
        protected string ID { get; set; }
        protected string Name { get; set; }
        protected double Cost { get; set; }
        protected int Amount { get; set; } 
        protected DateTime LastDelivery { get; set; }

        //Конструктор
        public Product(string id, string name, double cost, int amount, DateTime lastDelivery)
        {
            ID = id;
            Name = name;
            Cost = cost;
            Amount = amount;
            LastDelivery = lastDelivery;
        }
        
        // Абстрактний метод для отримання одиниці виміру
        public abstract string GetUnit();

        // Метод для розрахунку загальної вартості
        public double CalculateTotalValue()
        {
            return Cost * Amount;
        }
        
        // Перевірка на уцінку
        public virtual bool NeedsDiscount(DateTime currentDate)
        {
            return (currentDate - LastDelivery).TotalDays > 30;  // Уцінка через 30 днів
        }

    }
}
