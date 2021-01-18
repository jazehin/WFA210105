using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat13_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var c in gbxRadioButtons.Controls)
            {
                (c as RadioButton).Click += RbnChanged;
            }
        }

        private void BtnSzamolClick(object sender, EventArgs e)
        {
            if (tbxNetto.Text == "")
            {
                MessageBox.Show("Adjon meg egy nettó árat!");
                return;
            }

            int ar;
            try
            {
                ar = int.Parse(tbxNetto.Text);
            }
            catch
            {
                MessageBox.Show("Adjon meg egy nettó árat!");
                return;
            }

            double afa = 0;
            foreach (var c in gbxRadioButtons.Controls)
            {
                if ((c as RadioButton).Checked) afa = double.Parse((c as RadioButton).Text.Remove((c as RadioButton).Text.Length - 1)) / 100;
            }

            tbxAfa.Text = Convert.ToString(Math.Round(ar * afa));
            tbxBrutto.Text = Convert.ToString(Math.Round(ar + ar * afa));
        }

        private void RbnChanged(object sender, EventArgs e)
        {
            tbxAfa.Text = "";
            tbxBrutto.Text = "";
        }
    }
}
