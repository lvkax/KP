using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KP
{

    public partial class fProductsInStock : Form
    {
        public List<Product> AvailableProducts { get; set; } 
        public fProductsInStock(List<Product> wantedProducts)
        {
            InitializeComponent();
            
            AvailableProducts = wantedProducts;
            gvStore.DataSource = AvailableProducts;
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            var fpd = new fProductsDelivery(AvailableProducts);
            fpd.ShowDialog();
            if(fpd.DialogResult == DialogResult.OK)
{
                gvStore.DataSource = null;
                gvStore.DataSource = AvailableProducts;
            }
        }

        private void btnStoreOK_Click(object sender, EventArgs e)
        {
            gvStore.DataSource = null;
            gvStore.DataSource = AvailableProducts;
            DialogResult = DialogResult.OK;
        }

        private void fProductsInStock_Load(object sender, EventArgs e)
        {
            LoadStockData("stock.json");

            gvStore.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Id";
            column.Name = "ID";
            gvStore.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Ім'я";
            gvStore.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Amount";
            column.Name = "Кількість";
            gvStore.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Cost";
            column.Name = "Ціна";
            gvStore.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CostPerAmountOfUnits";
            column.Name = "За кількіть грам";
            gvStore.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PackSize";
            column.Name = "Розмір";
            gvStore.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Закупівельна ціна";
            gvStore.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "LastDelivery";
            column.Name = "Остання поставка";
            column.Width = 120;
            gvStore.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "NeedsDiscount";
            column.Name = "Потребує в знижці";
            column.Width = 40;
            gvStore.Columns.Add(column);

        }

        public void SaveStockData(string filePath)
        {
            string json = JsonConvert.SerializeObject(AvailableProducts, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveStockData("stock.json");
            MessageBox.Show("База склада успішно збережена!");
        }

        public void LoadStockData(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                AvailableProducts = JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
                gvStore.DataSource = null;
                gvStore.DataSource = AvailableProducts; // Обновить таблицу
            }
            else
            {
                MessageBox.Show("Файл бази наявності не знайдений!");
            }
        }

        private void btnOpenSaved_Click(object sender, EventArgs e)
        {

        }
    }
}
