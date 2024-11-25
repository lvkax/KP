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
    public partial class fProductsInStock : Form
    {
        public fProductsInStock()
        {
            InitializeComponent();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            fProductsDelivery fd = new fProductsDelivery();
            fd.ShowDialog();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            fAddProduct fa = new fAddProduct();
            fa.ShowDialog();
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
            column.DataPropertyName = "Unit";
            column.Name = "Од.виміру";
            gvStore.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "LastDelivery";
            column.Name = "Остання поставка";
            gvStore.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TotalCost";
            column.Name = "Загальна ціна";
            gvStore.Columns.Add(column);
        }
    }
}
