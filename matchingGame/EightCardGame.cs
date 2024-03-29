﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace matchingGame
{
    public partial class EightCardGame : Form
    {
        Random random = new Random();

        Functions methods = new Functions();

        List<string> icons;

        Label firstClicked = null;
        Label secondClicked = null;

        private Stopwatch stopWatch;

        public EightCardGame()
        {
            InitializeComponent();
            stopWatch = new Stopwatch();
            methods.ResetGame(layoutEightCards.Controls, icons);
            icons = methods.GenerateIcons(4);
            methods.AssignIconsToSquares(layoutEightCards.Controls, icons);
            methods.CheckForWinner(layoutEightCards.Controls, stopWatch);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();

            if (timer1.Enabled == true)
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

                methods.CheckForWinner(layoutEightCards.Controls, stopWatch);
                stopWatch.Stop();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void EightCardGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameInterface form2 = new GameInterface();
            form2.Show();

            if (e.Cancel)
            {
                return;
            }
        }
    }
}
