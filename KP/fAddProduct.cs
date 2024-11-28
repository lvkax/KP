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
        public event EventHandler<Product> ProductAdded;
        int RecId;
        public fAddProduct(int recId)
        {
            RecId = recId;
            InitializeComponent();
        }



        private void btnNewProductOK_Click(object sender, EventArgs e)
        {
            string id = tbAddID.Text;
            string name = tbAddName.Text;
            int amount = 0;
            double cost = Double.Parse(tbAddCost.Text);
            double price = Double.Parse(tbAddPrice.Text);
            double costPerAmountOfUnits;
            string packSize = tbAddPackSize.Text;
            DateTime lastDelivery = DateTime.MinValue;
            //CalculateTotalValue
            Product newProduct = null;

            if (cbPacked.Checked)
            {
                
                newProduct = new Packed(id, name, amount,cost, price,  lastDelivery, packSize);
            }
            else if (cbWeighted.Checked)
            {
                packSize = "N/A";
                costPerAmountOfUnits = Double.Parse(tbAddCostPerAmountOfUnits.Text);
                newProduct = new Weighted(id, name, amount,cost, price,  lastDelivery, costPerAmountOfUnits);
            }

            if (newProduct != null)
            {
                ProductAdded?.Invoke(this, newProduct);
                this.Close();
            }
            else { MessageBox.Show("Вибиріть тип продукту"); }
        }

        private void btnNewProductCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void fAddProduct_Load(object sender, EventArgs e)
        {
            tbAddID.Text = RecId.ToString();
        }

        private void tbAddID_TextChanged(object sender, EventArgs e)
        {
            if (tbAddID.Text == RecId.ToString())
            { lbRecomended.Visible = true; }
            else { lbRecomended.Visible = false; }
        }
        private void cbPacked_CheckedChanged(object sender, EventArgs e)
        {
            lbWorP.Text = "Розмір упаковки";
            tbAddCostPerAmountOfUnits.Enabled = false;
            tbAddCostPerAmountOfUnits.Visible = false;
            tbAddPackSize.Enabled = true;
            tbAddPackSize.Visible = true;
            lbGram.Visible = false;
        }

        private void cbWeighted_CheckedChanged(object sender, EventArgs e)
        {
            lbWorP.Text = "Ціна за ";
            tbAddCostPerAmountOfUnits.Visible = true;
            tbAddCostPerAmountOfUnits.Enabled = true;
            tbAddPackSize.Enabled = false;
            tbAddPackSize.Visible = false;
            lbGram.Visible = true;
        }
    }
}
