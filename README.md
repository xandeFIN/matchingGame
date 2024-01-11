# Matching Game with three difficulties
This repository consists a simple Matching game with three difficulties:

- Novice with 8 cards
- Normal with 16 cards
- Hard with 36 cards

This ReadMe will get completed as the code is ready - so stay tuned.

## Manual
This particular game is quite simple with user friendly interface. No keyboard is needed in any actions - just use your mouse to select gamemode or to pick a card.

### Sample Code

      public EightCardGame()
        {
            InitializeComponent();
            stopWatch = new Stopwatch();
            methods.ResetGame(layoutEightCards.Controls, icons);
            icons = methods.GenerateIcons(4);
            methods.AssignIconsToSquares(layoutEightCards.Controls, icons);
            methods.CheckForWinner(layoutEightCards.Controls, stopWatch);
        }

