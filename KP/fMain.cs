using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class fMain : Form
    {
        public List<Product> AvailableProducts { get; set; }
        public List<Product> WantedProducts { get; set; }
        public double sum;
        public fMain()
        {
            AvailableProducts = new List<Product>();
            WantedProducts = new List<Product>();
            InitializeComponent();
            gvCheck.DataSource = WantedProducts;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvCheck.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Ім'я";
            column.Width = 120;
            gvCheck.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PackSize";
            column.Name = "Розмір";
            column.Width = 60;
            gvCheck.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Amount";
            column.Name = "Кількість";
            column.Width = 60;
            gvCheck.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Cost";
            column.Name = "Ціна";
            column.Width = 80;
            gvCheck.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CostPerAmountOfUnits";
            column.Name = "За кількість грам";
            column.Width = 60;
            gvCheck.Columns.Add(column);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
           var fps = new fProductsInStock(AvailableProducts);
           fps.Show();
        }
        private void btnCardPaying_Click(object sender, EventArgs e)
        {
            CardPaying cp = new CardPaying();
            cp.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {

                foreach (var wantedProduct in WantedProducts)
                {
                    // Найти соответствующий продукт в AvailableProducts
                    var availableProduct = AvailableProducts.FirstOrDefault(p => p.ID == wantedProduct.ID);

                    // Если продукт найден, обновить его количество
                    if (availableProduct != null)
                    {
                        if (availableProduct.Amount >= wantedProduct.Amount)
                        {
                            availableProduct.Amount -= wantedProduct.Amount;
                        }
                        else
                        {
                            MessageBox.Show($"Недостаточно товара {availableProduct.Name} на складе!");
                        }
                    }
                }

                // Очистить чек
                WantedProducts.Clear();

                // Обновить привязку данных
                gvCheck.DataSource = null;
                gvCheck.DataSource = WantedProducts;

            }

        }
        private void btnCashPaying_Click(object sender, EventArgs e)
        {
            CashPaying cap = new CashPaying(sum);
            cap.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {

                foreach (var wantedProduct in WantedProducts)
                {
                    // Найти соответствующий продукт в AvailableProducts
                    var availableProduct = AvailableProducts.FirstOrDefault(p => p.ID == wantedProduct.ID);

                    // Если продукт найден, обновить его количество
                    if (availableProduct != null)
                    {
                        if (availableProduct.Amount >= wantedProduct.Amount)
                        {
                            availableProduct.Amount -= wantedProduct.Amount;
                        }
                        else
                        {
                            MessageBox.Show($"Недостаточно товара {availableProduct.Name} на складе!");
                        }
                    }
                }


                // Очистить чек
                WantedProducts.Clear();

                // Обновить привязку данных
                gvCheck.DataSource = null;
                gvCheck.DataSource = WantedProducts;

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }


        private void btnAddtoCheck_Click(object sender, EventArgs e)
        {
            // Получение ID и количества из полей
            var productId = tbID.Text.Trim();
            if (!int.TryParse(tbAmount.Text.Trim(), out int amountToAdd) || amountToAdd <= 0)
            {
                MessageBox.Show("Некорректное количество товара.");
                return;
            }

            // Поиск товара в списке AvailableProducts
            var product = AvailableProducts.FirstOrDefault(p => p.ID == productId);
            if (product == null)
            {
                MessageBox.Show("Товар не найден.");
                return;
            }

            // Проверка остатка товара
            if (product.Amount < amountToAdd)
            {
                MessageBox.Show("Недостаточно товара в наличии.");
                return;
            }

            // Поиск товара в списке WantedProducts
            var wantedProduct = WantedProducts.FirstOrDefault(p => p.ID == productId);
            if (wantedProduct == null)
            {
                // Если товар отсутствует в чеке, создаем новый объект на основе типа товара
                if (product is Packed packedProduct)
                {
                    wantedProduct = new Packed
                    {
                        ID = packedProduct.ID,
                        Name = packedProduct.Name,
                        Cost = packedProduct.Cost,
                        Price = packedProduct.Price,
                        PackSize = packedProduct.PackSize,
                        LastDelivery = packedProduct.LastDelivery,
                        Amount = amountToAdd
                    };
                }
                else if (product is Weighted weightedProduct)
                {
                    wantedProduct = new Weighted
                    {
                        ID = weightedProduct.ID,
                        Name = weightedProduct.Name,
                        Cost = weightedProduct.Cost,
                        Price = weightedProduct.Price,
                        CostPerAmountOfUnits = weightedProduct.CostPerAmountOfUnits,
                        LastDelivery = weightedProduct.LastDelivery,
                        Amount = amountToAdd
                    };
                }

                WantedProducts.Add(wantedProduct);
            }
            else
            {
                // Если товар уже в чеке, просто увеличиваем его количество
                wantedProduct.Amount += amountToAdd;
            }

            // Обновление остатка товара
            product.Amount -= amountToAdd;

            // Очистка полей ввода
            tbID.Clear();
            tbAmount.Clear();

            // Обновление таблицы gvCheck
            gvCheck.DataSource = null;
            gvCheck.DataSource = WantedProducts;
        }

        private void gvCheck_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            sum = WantedProducts.Sum(p => p.CalculateTotalValue());
            tbTotalCost.Text = $"{sum:F2} ₴";
        }

    }
}
