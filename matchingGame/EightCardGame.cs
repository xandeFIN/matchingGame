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
using System.Net;

namespace matchingGame
{
    public partial class EightCardGame : Form
    {
        // This Random uses an object to choose random icons for the squares/cards
        Random random = new Random();

        Functions methods = new Functions();

        /* Each of these letters is an icon in the Webdings font,
         and each icon appears twice in this list
        */

        List<string> icons;

        Label firstClicked = null;
        Label secondClicked = null;

        private Stopwatch stopWatch;

        /* ALKUPERÄISTÄ KOODIA
         private void AssignIconsToSquares()
        {
            foreach (Control control in layoutEightCards.Controls)
            {
              Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }              
            }
        }
        */

        
        /* ALKUPERÄINEN KOODI
        private void CheckForWinner()
        {
            foreach (Control control in layoutEightCards.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                    return;
                }
            }
            MessageBox.Show("You matched all the icons!", "Congratulations!");

            double elapsedTimeSeconds = stopWatch.Elapsed.TotalSeconds;
            string format = "F2";

            MessageBox.Show($"Your time was {elapsedTimeSeconds.ToString(format)} s");
            DialogResult result = MessageBox.Show("Do you want to try again?", "Yes or No", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ResetGame();
            }      
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }
        */
        
        
        /* ALKUPERÄINEN KOODI
        private void ResetGame()
        {
            // Tyhjennä aiemman pelin tila
            foreach (Control control in layoutEightCards.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    iconLabel.Text = string.Empty;
                    iconLabel.ForeColor = Color.Black;
                }
            }

            // Palauta alkuperäiset kuvakkeet
            //icons.AddRange(new List<string> { "!", "!", "N", "N", ",", ",", "k", "k" });
            icons = methods.GenerateIcons(4);

            // Sekoita kuvakkeet
            methods.AssignIconsToSquares(layoutEightCards.Controls, icons);

            // Nollaa ajanotto
            stopWatch.Reset();
        }
        */

        public EightCardGame()
        {
            InitializeComponent();
            stopWatch = new Stopwatch();
            methods.ResetGame(layoutEightCards.Controls, icons);
            icons = methods.GenerateIcons(4);
            methods.AssignIconsToSquares(layoutEightCards.Controls, icons);
            methods.CheckForWinner(layoutEightCards.Controls, stopWatch);
            //PlayAgain(); -- TÄMÄ UUDELLEEN PELAAMISEN MAHDOLLISUUS KUNTOON -- 7.12.2023
        }

       /* private void PlayAgain()
        {
            DialogResult result = MessageBox.Show("Do you want to try again?", "Yes or No", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                methods.ResetGame(layoutEightCards.Controls, icons);
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }
       */
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
    }
}
