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
        public fAddProduct()
        {
            InitializeComponent();
        }

        int recID = 0;

        private void btnNewProductOK_Click(object sender, EventArgs e)
        {

        }

        private void btnNewProductCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void fAddProduct_Load(object sender, EventArgs e)
        {
            
            tbAddID.Text = recID.ToString();
            cbUnit.Items.Add("Шт.");
            cbUnit.Items.Add("Грам");
            
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

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUnit.SelectedIndex == 0) 
            { 
                lbWorP.Text = "Розмір упаковки";
            }
            else if (cbUnit.SelectedIndex == 1)
            {
                lbWorP.Text = "За вагу";
            }
        }
    }
}
