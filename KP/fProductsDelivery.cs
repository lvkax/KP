using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class fProductsDelivery : Form
    {
        public BindingList<Product> PossProducts { get; set; }
        public List<Product> AvailableProducts { get; set; }

        public int recID;
        public fProductsDelivery(List<Product> availableProducts)
        {
            InitializeComponent();
            PossProducts = new BindingList<Product>();
            AvailableProducts = availableProducts; 
            gvDelivery.DataSource = PossProducts;
        }


        private void fProductsDelivery_Load(object sender, EventArgs e)
        {
            gvDelivery.AutoGenerateColumns = false;

            gvDelivery.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvDelivery.MultiSelect = true;

        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            recID = gvDelivery.RowCount + 1;
            var fa = new fAddProduct(recID);
            fa.ProductAdded += (s, product) =>
            {
                PossProducts.Add(product);
                AvailableProducts.Add(product);
                gvDelivery.DataSource = null;
                gvDelivery.DataSource = PossProducts;

            };
            fa.Show();
        }

        private void btnDeliveryOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void gvDelivery_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gvDelivery.CurrentRow?.DataBoundItem is Product selectedItem)
            {
            }
        }
        private void btnDeliver_Click(object sender, EventArgs e)
        {
            foreach (var product in AvailableProducts.ToList())
            {

                product.GetUnit();
                product.LastDelivery = DateTime.Now;
                product.CalculateTotalValue();
                if (product.Amount == 0)
                {
                    AvailableProducts.Remove(product);
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}
