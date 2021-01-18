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

namespace feladat13_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Jelentkezo
        {
            public string Nev;
            public int SzuletesiEv;
            public string Nyelv;
            public string Szint;

            public Jelentkezo(string nev, int szuletesiev, string nyelv, string szint)
            {
                Nev = nev;
                SzuletesiEv = szuletesiev;
                Nyelv = nyelv;
                Szint = szint;
            }

            public override string ToString() => $"{Nev},{SzuletesiEv},{Szint}";
            
        }

        List<Jelentkezo> listJelentkezok = new List<Jelentkezo>();

        private void BtnAdatbevitelClick(object sender, EventArgs e)
        {
            if (tbxNev.Text == "")
            {
                MessageBox.Show("Adja meg a nevét!");
                return;
            }

            int ev;
            try
            {
                ev = int.Parse(tbxEv.Text);
            }
            catch
            {
                MessageBox.Show("Érvényes évszámot adjon meg!");
                return;
            }

            if (ev > DateTime.Now.Year /*még ez sem igazán jó, mert egy újszülött(et) nem regisztrál(nak) nyelvtanfolyamokra, de mindegy*/ || ev < 1900)
            {
                MessageBox.Show("Érvényes évszámot adjon meg!");
                return;
            }

            listJelentkezok.Add(new Jelentkezo(tbxNev.Text, ev, cbxNyelv.Text, cbxSzint.Text));
        }

        private void BtnValogatasClick(object sender, EventArgs e)
        {
            var angol = new StreamWriter(@"../../res/angol.txt", true);
            var nemet = new StreamWriter(@"../../res/nemet.txt", true);
            var francia = new StreamWriter(@"../../res/francia.txt", true);

            foreach (var j in listJelentkezok)
            {
                switch (j.Nyelv)
                {
                    case "angol":
                        angol.WriteLine(j.ToString());
                        break;
                    case "német":
                        nemet.WriteLine(j.ToString());
                        break;
                    case "francia":
                        francia.WriteLine(j.ToString());
                        break;
                }
            }

            angol.Flush();
            angol.Close();
            nemet.Flush();
            nemet.Close();
            francia.Flush();
            francia.Close();
        }
    }
}
