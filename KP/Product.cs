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
        public string ID { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public DateTime LastDelivery { get; set; }
        public virtual string PackSize { get; set; }
        public virtual double CostPerAmountOfUnits { get; set; }

        //Конструктор
        public Product(string id, string name, double cost, double price, int amount, DateTime lastDelivery)
        {
            ID = id;
            Name = name;
            Cost = cost;
            Price = price;
            Amount = amount;
            LastDelivery = lastDelivery;
        }
        public Product() { }

        // Метод для отримання одиниці виміру
        public abstract string GetUnit();

        // Метод для розрахунку загальної вартості
        public abstract double CalculateTotalValue();


        // Перевірка на уцінку
        public virtual bool NeedsDiscount(DateTime currentDate)
        {
            return (currentDate - LastDelivery).TotalDays > 30;  // Уцінка через 30 днів
        }

    }
}
