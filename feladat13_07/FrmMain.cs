using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat13_07
{
    public partial class FrmMain : Form
    {
        public FontConverter vmi = new FontConverter();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ChbxChanged(object sender, EventArgs e)
        {
            string fontString = vmi.ConvertToString(new Font(FontFamily.GenericSansSerif, 12.0f));

            List<string> formazasok = new List<string>();

            foreach (var c in Controls)
            {
                if (c is CheckBox && (c as CheckBox).Checked) {
                    switch((c as CheckBox).Text)
                    {
                        case "Félkövér":
                            formazasok.Add("Bold");
                            break;
                        case "Dőlt":
                            formazasok.Add("Italic");
                            break;
                        case "Aláhúzott":
                            formazasok.Add("Underline");
                            break;
                    }
                }
            }

            lblFormat.Font = vmi.ConvertFromString(string.Format($"{fontString}{FormatString(formazasok)}")) as Font;

            //na erre kíváncsi leszek, hogyan csinálná a Tanárúr, magamtól ezt tudtam összehozni
        }

        private string FormatString(List<string> list)
        {
            if (list.Count == 0) return "";

            string returnValue = ", style=";

            for (int i = 0; i < list.Count; i++)
            {
                returnValue += list[i];
                if (i + 1 < list.Count) returnValue += ", ";
            }

            return returnValue;
        }
    } 
}
