using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_9
{
    public partial class FrmMain : Form
    {
        ListBox.ObjectCollection collection;
        public FrmMain()
        {
            InitializeComponent();
            collection = new ListBox.ObjectCollection(lbx);
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            if (tbxInput.Text == "") return;

            collection.Add(tbxInput.Text);
        }

        private void BtnDeleteAllClick(object sender, EventArgs e)
        {
            collection.Clear();
        }

        private void BtnDeleteSelectedClick(object sender, EventArgs e)
        {
            collection.RemoveAt(lbx.SelectedIndex);
        }
    }
}
