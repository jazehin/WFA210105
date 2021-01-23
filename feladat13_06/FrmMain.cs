using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat13_06
{
    public partial class FrmMain : Form
    {
        struct Valuta
        {
            public string Nev;
            public double Vetel;
            public double Eladas;

            public Valuta(string sor)
            {
                var t = sor.Split(';');

                Nev = t[0];
                Vetel = double.Parse(t[1]);
                Eladas = double.Parse(t[2]);
            }
        }

        List<Valuta> valutak = new List<Valuta>();
        Dictionary<string, string> valutaRovidNev = new Dictionary<string, string>();

        public FrmMain()
        {
            InitializeComponent();

            //Megjegyzés: a valuta.txt-t 21.01.23.-án készítettem a napiarfolyam.hu adatai szerint.

            StreamReader sr = new StreamReader(@"../../res/valuta.txt", Encoding.UTF8, false);
            while (!sr.EndOfStream)
            {
                valutak.Add(new Valuta(sr.ReadLine()));
            }
            sr.Close();

            //ComboBox.ObjectCollection items = new ComboBox.ObjectCollection(cbxValuta);

            foreach (var v in valutak)
            {
                cbxValuta.Items.Add(v.Nev);
            }

            valutaRovidNev.Add("Euró", "EUR");
            valutaRovidNev.Add("Amerikai dollár", "USD");
            valutaRovidNev.Add("Ausztrál dollár", "AUD");
            valutaRovidNev.Add("Angol font", "GBP");
        }

        private void BtnOKClicked(object sender, EventArgs e)
        {
            if (tbxOsszeg.Text == "")
            {
                MessageBox.Show(string.Format("Nincs kitöltve a{0} összege!", rbtnVetel.Checked ? " vásárlás" : "z eladás"));
                return;
            }

            if (cbxValuta.Text == "")
            {
                MessageBox.Show("Nincs kiválasztva valuta!");
                return;
            }

            tbxEredmeny.Text = Convert.ToString(double.Parse(tbxArfolyam.Text)*double.Parse(tbxOsszeg.Text));
        }

        private void RbtnClick(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Text == "Vétel")
            {
                lblOsszeg.Text = "Vásárlás összege:";
                lblEredmeny.Text = "Fizetendő:";
            }
            else
            {
                lblOsszeg.Text = "Eladás összege:";
                lblEredmeny.Text = "Ellenérték:";
            }

            ArfolyamAtiras();
        }

        private void CbxValutaChanged(object sender, EventArgs e)
        {
            lblValuta.Text = valutaRovidNev[cbxValuta.Text];

            ArfolyamAtiras();
        }

        private void ArfolyamAtiras()
        {
            int i = 0;
            while (i < valutak.Count && valutak[i].Nev != cbxValuta.Text) i++;

            if (i < valutak.Count) tbxArfolyam.Text = Convert.ToString(rbtnVetel.Checked ? valutak[i].Vetel : valutak[i].Eladas);
            else tbxArfolyam.Text = "";

            tbxEredmeny.Text = "";
        }

        private void TbxOsszegChanged(object sender, EventArgs e)
        {
            tbxEredmeny.Text = "";
        }
    }
}
