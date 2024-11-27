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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvCheck.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
           
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
           var fps = new fProductsInStock();
           fps.ShowDialog();
        }
        private void btnCardPaying_Click(object sender, EventArgs e)
        {
            CardPaying cp = new CardPaying();
            cp.ShowDialog();
        }
        private void btnCashPaying_Click(object sender, EventArgs e)
        {
            CashPaying cap = new CashPaying();
            cap.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
                       
        }
    }
}
