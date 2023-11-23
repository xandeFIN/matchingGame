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
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            SixteenCardGame newWindow = new SixteenCardGame();
            newWindow.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            ThirtyTwoCardGame newWindow = new ThirtyTwoCardGame();
            newWindow.Show();
        }
    }
}
