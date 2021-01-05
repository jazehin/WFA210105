using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_12
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCountClick(object sender, EventArgs e)
        {
            int a, b, c;
            try
            {
                a = int.Parse(tbxA.Text);
                b = int.Parse(tbxB.Text);
                c = int.Parse(tbxC.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Hiba lépett fel");
                return;
            }

            double discriminant = Math.Pow(b, 2) - 4 * a * c; //diszkrimináns: gyök alatti rész

            //fvtábla szerint eljárva:
            
            if (discriminant < 0)
            {
                MessageBox.Show("Negatív számból nem lehet gyököt vonni", "Hiba lépett fel");
            }
            else if (discriminant == 0)
            {
                lblX1.Text = $"x = {(-b + Math.Sqrt(discriminant)) / (2 * a)}";
                lblX2.Text = "";
            }
            else
            {
                lblX1.Text = $"x1 = {(-b + Math.Sqrt(discriminant)) / (2 * a)}";
                lblX2.Text = $"x2 = {(-b - Math.Sqrt(discriminant)) / (2 * a)}";
            }
        }
    }
}
