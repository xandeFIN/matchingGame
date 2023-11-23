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
    public partial class EightCardGame : Form
    {

        // This Random uses an object to choose random icons for the squares/cards
        Random random = new Random();

        /* Each of these letters is an icon in the Webdings font,
         and each icon appears twice in this list
        */
        List<string> icons = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k"
    };

        Label firstClicked = null;
        Label secondClicked = null;

        private Stopwatch stopWatch;

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
           /* DialogResult result = MessageBox.Show("Do you want to try again?", "Yes or No", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                new EightCardGame();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
           */
        }

        public EightCardGame()
        {
            InitializeComponent();
            AssignIconsToSquares();
            stopWatch = new Stopwatch();
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

                CheckForWinner();
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
