using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace matchingGame
{
    internal class Functions
    {
        int pairCounter = 0;

        public List<string> GenerateIcons(int pairCount)
        {
            List<string> icons = new List<string>();
            char currentIcon = 'A';

            for (int i = 0; i < pairCount; i++)
            {
                icons.Add(currentIcon.ToString());
                icons.Add(currentIcon.ToString());
                currentIcon++;
            }
            pairCounter = pairCount;
            return icons;
        }

        public void AssignIconsToSquares(Control.ControlCollection controls, List<string> icons)
        {
            Random random = new Random();

            foreach (Control control in controls)
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

        public void ResetGame(Control.ControlCollection controls, List<string> icons)
        {
            foreach (Control control in controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    iconLabel.Text = string.Empty;
                    iconLabel.ForeColor = Color.Black;
                }
            }
            icons = GenerateIcons(pairCounter);
        }

        public void CheckForWinner(Control.ControlCollection controls, Stopwatch stopWatch)
        {
            foreach (Control control in controls)
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

            Form.ActiveForm.Close();
        }
    }
}
