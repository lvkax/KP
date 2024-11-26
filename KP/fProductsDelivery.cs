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
        public fProductsDelivery()
        {
            InitializeComponent();

        }

        private void fProductsDelivery_Load(object sender, EventArgs e)
        {
            gvDelivery.DataSource = bindSrDelivery;

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

        private void btnAddNewWeighted_Click(object sender, EventArgs e)
        {
            Product product = new Weighted();
    fAddProduct fa = new fAddProduct(product);
    if (fa.ShowDialog() == DialogResult.OK)
    {
        // Додавання продукту через BindingSource
        bindSrDelivery.Add(product);
    }
        }

        private void btnAddNewPacked_Click(object sender, EventArgs e)
        {
            Product product = new Packed();
            fAddProduct fa = new fAddProduct(product);
            if (fa.ShowDialog() == DialogResult.OK)
            {
                // Додавання продукту через BindingSource
                bindSrDelivery.Add(product);
            }
        }
    }
}
