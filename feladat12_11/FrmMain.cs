using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_11
{
    public partial class FrmMain : Form
    {
        struct Diak
        {
            public string Name;
            public int Points;

            public Diak(string name, int points)
            {
                Name = name;
                Points = points;
            }
        }

        List<Diak> diakok = new List<Diak>();
        ListBox.ObjectCollection collection;
        public FrmMain()
        {
            InitializeComponent();
            collection = new ListBox.ObjectCollection(lbxData);
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            int points;
            try
            {
                points = int.Parse(tbxPoints.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Hiba lépett fel");
                return;
            }
            string name = tbxName.Text;

            diakok.Add(new Diak(name, points));

            collection.Add($"{name} : {points}");
        }

        private void BtnAvgClick(object sender, EventArgs e)
        {
            if (diakok.Count == 0) return;

            double avg = 0;

            foreach (var diak in diakok)
            {
                avg += diak.Points;
            }

            lblAvg.Text = $"{(avg / diakok.Count):0.00} pont";
        }
    }
}
