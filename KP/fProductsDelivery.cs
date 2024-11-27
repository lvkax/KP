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
    public partial class fProductsDelivery : Form
    {
        public List<Product> Products { get; set; }
        public int recID;
        public fProductsDelivery()
        {
            InitializeComponent();
            Products = new List<Product>();
            gvDelivery.DataSource = Products;
        }

        private void fProductsDelivery_Load(object sender, EventArgs e)
        {
            gvDelivery.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Id";
            column.Name = "ID";
            gvDelivery.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Ім'я";
            gvDelivery.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Amount";
            column.Name = "Кількість";
            gvDelivery.Columns.Add(column);
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            recID = gvDelivery.RowCount + 1;
            var fa = new fAddProduct(recID);
            fa.ProductAdded += (s, product) =>
            {
                Products.Add(product);
                gvDelivery.DataSource = null;
                gvDelivery.DataSource = Products;

            };
            fa.Show();
        }

        private void btnDeliveryOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {

        }
    }
}
