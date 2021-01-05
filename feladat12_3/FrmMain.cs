using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_3
{
    public partial class FrmMain : Form
    {
        Color defaultColour;
        public FrmMain()
        {
            InitializeComponent();
            defaultColour = this.BackColor;
        }

        private void LblAquamarineClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
        }

        private void LblLimeClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
        }

        private void LblIndigoClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Indigo;
        }

        private void LblHotPinkClick(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
        }

        private void BtnDefaultClick(object sender, EventArgs e)
        {
            this.BackColor = defaultColour;
        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
