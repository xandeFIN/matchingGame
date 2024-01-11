# Matching Game with three difficulties
This repository consists a simple Matching game with three difficulties:

- Novice with 8 cards
- Normal with 16 cards
- Hard with 36 cards

## Manual
This particular game is quite simple with user friendly interface. No keyboard is needed in any actions - just use your mouse to select gamemode or to pick a card.
Game interface asks game difficulty and executes selected game mode. After completing particular game mode, active mode closes and you can choose difficulty again or close program.

Examples about the game logic below:

![gameInterface](https://github.com/xandeFIN/matchingGame/assets/109038247/1d431cdd-730c-44ad-b617-f6c649119ea4)
![difficultyEasy](https://github.com/xandeFIN/matchingGame/assets/109038247/1a052521-5264-4d34-95c1-876c9d3ade90)
![youMatchedAll](https://github.com/xandeFIN/matchingGame/assets/109038247/f15c04cd-f116-49fa-b1a9-ab379df6e6a5)
![displayTime](https://github.com/xandeFIN/matchingGame/assets/109038247/2a1f3d6f-b23a-4c03-ad18-053f1d3c0e4a)

Normal and Hard gamemodes both works with same logic.

### Sample Code
### Functions:

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

### Game specific logic:

      public EightCardGame()
        {
            InitializeComponent();
            stopWatch = new Stopwatch(); // Starts stopwatch
            methods.ResetGame(layoutEightCards.Controls, icons); // Sets layout
            icons = methods.GenerateIcons(4); // Here you set up how many icons are displayed in a game
            methods.AssignIconsToSquares(layoutEightCards.Controls, icons);
            methods.CheckForWinner(layoutEightCards.Controls, stopWatch);
        }


### Flow chart

![vuokaavio](https://github.com/xandeFIN/matchingGame/assets/109038247/7bd9e69f-da29-45ea-b2a2-3bcfd5b4afef)

### Future improvements

Some features displayed in the flow chart did not end up in the final release. For future releases I'd consider adding "Save High Score" -feature and during gameplay, after completing the gamemode, it'd query player if you'd want to play again.
