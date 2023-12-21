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
    public partial class ThirtySixCardGame : Form
    {
        
        Random random = new Random();

        Functions methods = new Functions();

        List<string> icons;

        Label firstClicked = null;
        Label secondClicked = null;

        private Stopwatch stopWatch;

        public ThirtySixCardGame()
        {
            InitializeComponent();
            stopWatch = new Stopwatch();
            methods.ResetGame(layout36Cards.Controls, icons);
            icons = methods.GenerateIcons(18);
            methods.AssignIconsToSquares(layout36Cards.Controls, icons);
            methods.CheckForWinner(layout36Cards.Controls, stopWatch);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            if (timer3.Enabled == true)
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

                methods.CheckForWinner(layout36Cards.Controls, stopWatch);
                stopWatch.Stop();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer3.Start();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void ThirtySixCardGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameInterface form4 = new GameInterface();
            form4.Show();

            if (e.Cancel)
            {
                return;
            }
        }
    }

}
