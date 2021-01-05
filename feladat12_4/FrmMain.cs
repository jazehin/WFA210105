using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_4
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnBlueCharClick(object sender, EventArgs e)
        {
            lblText.ForeColor = Color.Blue;
        }

        private void BtnWhiteBackClick(object sender, EventArgs e)
        {
            lblText.BackColor = Color.White;
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            lblText.Text = "";
        }

        private void BtnLeftCentreClick(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void BtnCentreCentreClick(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void BtnRightCentreClick(object sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleRight;
        }

        private void BtnCapitalClick(object sender, EventArgs e)
        {
            lblText.Text = lblText.Text.ToUpper();
        }

        private void BtnZoomInClick(object sender, EventArgs e)
        {
            lblText.Font = new Font(lblText.Font.FontFamily.Name, lblText.Font.Size + 1);
        }

        private void BtnZoomOutClick(object sender, EventArgs e)
        {
            if (lblText.Font.Size - 1 > 0) lblText.Font = new Font(lblText.Font.FontFamily.Name, lblText.Font.Size - 1);
            else MessageBox.Show("Ennél kisebb már nem lehet a betűméret!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnDefaultClick(object sender, EventArgs e)
        {
            lblText.ForeColor = Label.DefaultForeColor;
            lblText.BackColor = Label.DefaultBackColor;
            lblText.Text = "Helló világ!";
            lblText.TextAlign = ContentAlignment.TopLeft;
            lblText.Font = Label.DefaultFont;
        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
