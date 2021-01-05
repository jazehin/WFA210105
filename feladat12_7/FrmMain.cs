using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_7
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void BtnThrowClick(object sender, EventArgs e)
        {
            int c;
            try
            {
                c = int.Parse(tbxCount.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Hiba lépett fel");
                return;
            }
            if (c <= 0)
            {
                MessageBox.Show("Ilyen keveset nem tudok dobni :(", "Hiba lépett fel");
                return;
            }

            tbxResult.Text = "";

            for (int i = 0; i < c; i++)
            {
                tbxResult.Text += $"{rnd.Next(1, 7)} ";
            }

        }
    }
}
