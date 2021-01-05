using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_10
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void BtnGenerateClick(object sender, EventArgs e)
        {
            int min, max;
            try
            {
                min = int.Parse(tbxMin.Text);
                max = int.Parse(tbxMax.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Hiba lépett fel");
                return;
            }
            if (min > max)
            {
                MessageBox.Show("A minimum érték nem lehet nagyobb, mint a maximum.", "Hiba lépett fel");
                return;
            }

            tbxResult.Text = "";

            for (int i = 0; i < 100; i++)
            {
                tbxResult.Text += $"{rnd.Next(min, max + 1)} ";
            }
        }
    }
}
