using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void TbxInputTextChanged(object sender, EventArgs e)
        {
            if (tbxInput.Text != "") tbxInput.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            else tbxInput.BackColor = Color.White;
        }

        private void BtnDisappearClick(object sender, EventArgs e)
        {
            pbxImage.Visible = false;
            btnDisappear.Enabled = false;
            btnReappear.Enabled = true;
        }

        private void BtnReappearClick(object sender, EventArgs e)
        {
            pbxImage.Visible = true;
            btnDisappear.Enabled = true;
            btnReappear.Enabled = false;
        }

        private void ImageWink(object sender, EventArgs e)
        {
            pbxImage.Image = Image.FromFile("../../res/wink.png");
        }

        private void ImageSmiley(object sender, EventArgs e)
        {
            pbxImage.Image = Image.FromFile("../../res/smiley.png");
        }

        private void ImageChangePos(object sender, EventArgs e)
        {
            pbxImage.Location = new Point(
                rnd.Next(this.Width - pbxImage.Width),
                rnd.Next(this.Height - pbxImage.Height));
        }
    }
}
