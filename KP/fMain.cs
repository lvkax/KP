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
        }
        private void btnCashPaying_Click(object sender, EventArgs e)
        {
            CashPaying cap = new CashPaying(sum);
            cap.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
                       
        }

        private void btnAddtoCheck_Click(object sender, EventArgs e)
        {
            foreach (var product in AvailableProducts.ToList())
            {
                //product.Amount = product.Amount - int.Parse(tbAmount.Text);
                if (product.ID == tbID.Text)
                {
                    product.Amount = int.Parse(tbAmount.Text);
                    tbID.Text = string.Empty;
                    tbAmount.Text = string.Empty;
                    WantedProducts.Add(product);
                    gvCheck.DataSource = null;
                    gvCheck.DataSource = WantedProducts;
                }
            }
        }

        private void gvCheck_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            sum = 0;
            foreach (var product in WantedProducts)
            {
                sum += product.CalculateTotalValue();
            }
            tbTotalCost.Text = sum.ToString("F2") + " ₴";
        }
    }
}
