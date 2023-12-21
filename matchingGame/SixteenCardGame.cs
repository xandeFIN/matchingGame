using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace matchingGame
{
    public partial class SixteenCardGame : Form
    {
        Random random = new Random();

        Functions methods = new Functions();

        List<string> icons;

        Label firstClicked = null;
        Label secondClicked = null;

        private Stopwatch stopWatch;

        public SixteenCardGame()
        {
            InitializeComponent();
            stopWatch = new Stopwatch();
            methods.ResetGame(layoutSixteenCards.Controls, icons);
            icons = methods.GenerateIcons(8);
            methods.AssignIconsToSquares(layoutSixteenCards.Controls, icons);
            methods.CheckForWinner(layoutSixteenCards.Controls, stopWatch);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            if (timer2.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                methods.CheckForWinner(layoutSixteenCards.Controls, stopWatch);
                stopWatch.Stop();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void SixteenCardGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameInterface form3 = new GameInterface();
            form3.Show();

            if (e.Cancel)
            {
                return;
            }
        }
    }
}
