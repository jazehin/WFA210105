using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_8
{
    public partial class FrmMain : Form
    {
        ListBox.ObjectCollection collection;
        public FrmMain()
        {
            InitializeComponent();
            collection = new ListBox.ObjectCollection(lbxDivisors);
        }

        private void BtnDivisorsClick(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(tbxNum.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Hiba lépett fel");
                return;
            }

            

            collection.Clear();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    collection.Add(i);
                }
            }
        }
    }
}
