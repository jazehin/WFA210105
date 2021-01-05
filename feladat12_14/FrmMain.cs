using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_14
{
    public partial class FrmMain : Form
    {
        ListBox.ObjectCollection collection;
        public FrmMain()
        {
            InitializeComponent();
            collection = new ListBox.ObjectCollection(lbxResult);
        }

        private void BtnCountClick(object sender, EventArgs e)
        {
            double a, b, c;
            try
            {
                a = int.Parse(tbxA.Text);
                b = int.Parse(tbxB.Text);
                c = Math.Sqrt(a * a + b * b);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Hiba lépett fel");
                return;
            }

            collection.Add($"a={a:0}, b={b:0}; c={c:0.00}");
        }
    }
}
