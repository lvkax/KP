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
    public partial class CashPaying : Form
    {
        double TotalCost = 0;
        public CashPaying(double totalCost)
        {
            InitializeComponent();
            TotalCost = totalCost;
        }

        private void btnCashYes_Click(object sender, EventArgs e)
        {

        }

        private void btnCashCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CashPaying_Load(object sender, EventArgs e)
        {
            tbCashPaying.Text = TotalCost.ToString();
        }

        private void tbGived_TextChanged(object sender, EventArgs e) 
        {
            if (tbGived.Text != string.Empty)
            {
                double topay = Double.Parse(tbCashPaying.Text);
                double gived = Double.Parse(tbGived.Text);
                double rest = gived - topay;
                tbRest.Text = rest.ToString() + " ₴";
            }
            
        }
    }
}
