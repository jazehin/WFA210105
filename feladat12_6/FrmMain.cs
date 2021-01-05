using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_6
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnTellClick(object sender, EventArgs e)
        {
            int min, max, n;
            try
            {
                min = int.Parse(tbxMin.Text);
                max = int.Parse(tbxMax.Text);
                n = int.Parse(tbxGiven.Text);
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

            if (n >= min && n <= max) //ez nem volt egyértelműen megadva, úgyhogy azok is benne vannak :)
            {
                lblResult.Text = "Benne van az intervallumban.";
            } else {
                lblResult.Text = "Nincs benne az intervallumban.";
            }
        }
    }
}
