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
    }
}
