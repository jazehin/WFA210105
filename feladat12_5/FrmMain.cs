using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_5
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            tbx1.Text = "";
            tbx2.Text = "";
            tbxResult.Text = "";
        }

        private void BtnASMDClick(object sender, EventArgs e)
        {
            double n, m;
            try
            {
                n = double.Parse(tbx1.Text);
                m = double.Parse(tbx2.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Hiba lépett fel");
                return;
            }

            if (sender == btnAddition) {
                tbxResult.Text = Convert.ToString(n + m);
                lblResult.Text = btnAddition.Text;
            } else if (sender == btnSubtraction) {
                tbxResult.Text = Convert.ToString(n - m);
                lblResult.Text = btnSubtraction.Text;
            } else if (sender == btnMultiplication) {
                tbxResult.Text = Convert.ToString(n * m);
                lblResult.Text = btnMultiplication.Text;
            } else {
                if (m == 0) {
                    MessageBox.Show("0-ával nem lehet osztani", "Hiba lépett fel");
                    return;
                }
                tbxResult.Text = Convert.ToString(n / m);
                lblResult.Text = btnDivision.Text;
            }
        }

        private void TxtTbChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Művelet eredménye";
            tbxResult.Text = "";
        }
    }
}
