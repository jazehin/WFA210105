using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat13_02
{
    public partial class FrmMain : Form
    {
        List<int> szamok = new List<int>();
        Random rnd = new Random();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSorsolasClick(object sender, EventArgs e)
        {
            string ki = "";

            switch (cbxTípusok.Text)
            {
                case "Ötöslottó":
                    ki = Sorsolas(5, 1, 90);
                    break;
                case "Hatoslottó":
                    ki = Sorsolas(6, 1, 45);
                    break;
                case "Skandináv lottó":
                    ki = $"Kézi: {Sorsolas(7, 1, 35)}\r\nGépi: {Sorsolas(7, 1, 35)}";
                    break;
                default:
                    break;
            }

            lblEredmény.Text = ki;
            lblEredmény.Visible = true;
            if (cbxTípusok.Text != "") pbxSzamok.Visible = false;
        }

        private string OutputString()
        {
            string ki = "";

            for (int i = 0; i < szamok.Count; i++)
            {
                ki += $"{szamok[i]}";
                if (i < szamok.Count - 1) ki += ", ";
            }

            return ki;
        }

        private string Rendezes()
        {
            for (int i = 0; i < szamok.Count - 1; i++)
            {
                for (int j = i + 1; j < szamok.Count; j++)
                {
                    if (szamok[i] >= szamok[j])
                    {
                        int t = szamok[j];
                        szamok[j] = szamok[i];
                        szamok[i] = t;
                    }
                }
            }
            
            return OutputString();
        }

        private string Sorsolas(int c, int min, int max)
        {
            szamok = new List<int>();

            for (int i = 0; i < c; i++)
            {
                int n = rnd.Next(min, max + 1);

                while (szamok.Contains(n)) //hogy ne legyen benne duplikált elem
                {
                    n = rnd.Next(min, max + 1);
                }

                szamok.Add(n);
            }

            return Rendezes();
        }

        private void LottoValtozott(object sender, EventArgs e)
        {
            lblEredmény.Visible = false;
            pbxSzamok.Visible = true;
        }
    }
}
