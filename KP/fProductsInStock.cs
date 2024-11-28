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

namespace KP
{

    public partial class fProductsInStock : Form
    {
        public List<Product> AvailableProducts { get; set; } 
        public fProductsInStock(List<Product> wantedProducts)
        {
            InitializeComponent();
            AvailableProducts = new List<Product>();
            gvStore.DataSource = AvailableProducts;
            AvailableProducts = wantedProducts;

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
            DialogResult = DialogResult.OK;
        }

        private void fProductsInStock_Load(object sender, EventArgs e)
        {
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

        }

    }
}
