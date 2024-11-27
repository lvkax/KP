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
        public BindingList<Product> AvailProducts { get; set; }
        public int recID;
        public fProductsDelivery(List<Product> AvailProducts)
        {
            
            InitializeComponent();
            PossProducts = new BindingList<Product>();
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
                
                selectedItem = gvDelivery.CurrentRow?.DataBoundItem as Product;
                AvailProducts.Add(selectedItem);
            }
        }
        private void btnDeliver_Click(object sender, EventArgs e)
        {
            if (gvDelivery.CurrentRow?.DataBoundItem is Product selectedItem)
            {

            }
        }
    }
}
