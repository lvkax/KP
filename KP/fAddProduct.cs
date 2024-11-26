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
    public partial class fAddProduct : Form
    {
        private Product TheProduct;
        public fAddProduct(Product p)
        {
            TheProduct = p;
            InitializeComponent();
        }
        

        int recID = 0;

        private void btnNewProductOK_Click(object sender, EventArgs e)
        {
            if(TheProduct is Packed packed)
            {
                TheProduct.ID = tbAddID.Text;
                TheProduct.Name = tbAddName.Text;
                TheProduct.Cost = Double.Parse(tbAddCost.Text);
                TheProduct.Price = Double.Parse(tbAddCost.Text);
                TheProduct.Amount = 0;
                TheProduct.LastDelivery = new DateTime();
                packed.PackSize = tbAddWorP.Text;
            }
            else if (TheProduct is Weighted weighted)
            {
                TheProduct.ID = tbAddID.Text;
                TheProduct.Name = tbAddName.Text;
                TheProduct.Cost = Double.Parse(tbAddCost.Text);
                TheProduct.Price = Double.Parse(tbAddCost.Text);
                TheProduct.Amount = 0;
                TheProduct.LastDelivery = new DateTime();
                weighted.CostPerAmountOfUnits = int.Parse(tbAddWorP.Text);
            }
            DialogResult = DialogResult.OK;
        }

        private void btnNewProductCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void fAddProduct_Load(object sender, EventArgs e)
        {
            tbAddID.Text = recID.ToString();
            if (TheProduct != null)
            {
                tbAddID.Text = TheProduct.ID;
                tbAddName.Text = TheProduct.Name;
                tbAddCost.Text = TheProduct.Cost.ToString();
                tbAddPrice.Text = TheProduct.Price.ToString();
            }
        }

        private void tbAddID_TextChanged(object sender, EventArgs e)
        {
            if (tbAddID.Text != recID.ToString())
            {
                lbRecomended.Visible = false;
            }
            else
            {
                lbRecomended.Visible = true;
            }
        }
    }
}
