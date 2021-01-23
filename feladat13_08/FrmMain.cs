using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat13_08
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, EventArgs e)
        {
            int ar = rbtnTea.Checked ? 80 : 120;

            if (chbxTej.Checked) ar += 60;
            if (chbxCukor.Checked) ar += 60;
            if (chbxCitrom.Checked) ar += 60;

            tbxFizetendo.Text = Convert.ToString(ar);
        }

        private void ValasztasValtozott(object sender, EventArgs e)
        {
            tbxFizetendo.Text = "";

            if (rbtnTea.Checked) chbxCitrom.Enabled = true;
            else
            {
                chbxCitrom.Enabled = false;
                chbxCitrom.Checked = false;
            }
        }
    }
}
