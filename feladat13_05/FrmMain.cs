using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat13_05
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSzamolasClick(object sender, EventArgs e)
        {
            int sportagTenyezo = rbtnGyaloglas.Checked ? 20 : rbtnBiciklizes.Checked ? 24 : 33;
            double idotartam = double.Parse(tbxIdotartam.Text);

            if (rbtnSik.Checked) tbxEnergia.Text = Convert.ToString(idotartam * (1.5 + sportagTenyezo) * 1.2);
            else tbxEnergia.Text = Convert.ToString(idotartam * (2 + sportagTenyezo) * 1.7);
        }
    }
}
