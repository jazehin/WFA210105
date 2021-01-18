using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat13_01
{
    public partial class FrmMain : Form
    {
        int c = 0; //tippek száma
        int g = new Random().Next(1, 21); //gondolt szám

        public FrmMain()
        {
            InitializeComponent();

            foreach (var c in Controls)
            {
                int n = int.Parse((c as Button).Name.Substring(6));
                (c as Button).Text = Convert.ToString(n);
                //(c as Button).Name = $"Btn{n}"; -> rájöttem, hogy nem kell
                (c as Button).Click += BtnClick;
            }
        }

        private void BtnClick(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;

            int t = int.Parse((sender as Button).Text);

            if (t == g)
            {
                MessageBox.Show($"Eltaláltad! {c}. próbálkozásra sikerült.");
                Application.Exit();
            }

            if (t < g) MessageBox.Show("Ennél többre gondoltam!");
            else MessageBox.Show("Ennél kevesebbre gondoltam!");

            c++;
        }
    }
}
