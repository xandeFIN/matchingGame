using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matchingGame
{
    public partial class GameInterface : Form
    {



        public GameInterface()
        {
            InitializeComponent();
        }

        private void btnNovice_Click(object sender, EventArgs e)
        {
            EightCardGame newWindow = new EightCardGame();
            newWindow.Show();
            this.Hide();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            SixteenCardGame newWindow = new SixteenCardGame();
            newWindow.Show();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            ThirtySixCardGame newWindow = new ThirtySixCardGame();
            newWindow.Show();
            this.Hide();
        }

        private void GameInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
