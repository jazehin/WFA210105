using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat12_13
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        enum RPS
        {
            Rock,
            Paper,
            Scissors
        }

        RPS player, comp;
        int playerPoints = 0, compPoints = 0;
        Random rnd = new Random();

        private void BtnClick(object sender, EventArgs e)
        {
            if (sender == btnPlayerRock) player = RPS.Rock;
            else if (sender == btnPlayerPaper) player = RPS.Paper;
            else player = RPS.Scissors;

            comp = (RPS)rnd.Next(3);

            Evaluate();
        }

        private void Evaluate()
        {
            if (player == comp)
            {
                ColorBtn(Color.Yellow);
                MessageBox.Show("Döntetlen");
            }
            else if ((player == RPS.Paper && comp == RPS.Rock) || (player == RPS.Rock && comp == RPS.Scissors) || (player == RPS.Scissors && comp == RPS.Paper))
            {
                ColorBtn(Color.Green);
                MessageBox.Show("Győztél");
                playerPoints++;
            } else
            {
                ColorBtn(Color.Red);
                MessageBox.Show("Vesztettél");
                compPoints++;
            }

            lblPlayerPoints.Text = $"{playerPoints} pont";
            lblCompPoints.Text = $"{compPoints} pont";

            DefaultColorBtn();
            
            
        }

        private void ColorBtn(Color color)
        {
            switch (player)
            {
                case RPS.Rock:
                    btnPlayerRock.BackColor = color;
                    break;
                case RPS.Paper:
                    btnPlayerPaper.BackColor = color;
                    break;
                case RPS.Scissors:
                    btnPlayerScissors.BackColor = color;
                    break;
            }
            switch (comp)
            {
                case RPS.Rock:
                    btnCompRock.BackColor = color;
                    break;
                case RPS.Paper:
                    btnCompPaper.BackColor = color;
                    break;
                case RPS.Scissors:
                    btnCompScissors.BackColor = color;
                    break;
            }
        }

        private void DefaultColorBtn()
        {
            switch (player)
            {
                case RPS.Rock:
                    btnPlayerRock.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                case RPS.Paper:
                    btnPlayerPaper.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                case RPS.Scissors:
                    btnPlayerScissors.BackColor = Color.FromArgb(225, 225, 225);
                    break;
            }
            switch (comp)
            {
                case RPS.Rock:
                    btnCompRock.BackColor = Color.FromArgb(204, 204, 204);
                    break;
                case RPS.Paper:
                    btnCompPaper.BackColor = Color.FromArgb(204, 204, 204);
                    break;
                case RPS.Scissors:
                    btnCompScissors.BackColor = Color.FromArgb(204, 204, 204);
                    break;
            }
        }
    }
}
