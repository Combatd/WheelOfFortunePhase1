using System;
using System.Collections.Generic;
using System.Text;

namespace WheelOfFortuneV2
{
    /// <summary>
    /// This class manages game turns
    /// </summary>
    public class GameManager
    {
        private Game currentGame;
        private Phrase currentPhrase;
        private Player currentPlayer;

        public GameManager(Game game, Phrase phrase, Player player)
        {
            currentGame = game;
            currentPhrase = phrase;
            currentPlayer = player;
        }

        /// <summary>
        /// Prompts the player to make a move
        /// and reads input
        /// </summary>
        public void PromptPlayerMove()
        {
            try
            {
                int moveSelection = Convert.ToInt32(Console.ReadLine());
                HandlePlayerMove(moveSelection);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid selection. Please choose a number.", e);
                ContinueGame();
            }
        }

        /// <summary>
        /// Handles player's move selection
        /// </summary>
        /// <param name="moveSelection"></param>     
        public void HandlePlayerMove(int moveSelection)
        {
            switch (moveSelection)
            {
                case 1:
                    Console.WriteLine("\nGuess the phrase:");
                    String playerStringInput = currentPlayer.guessPhrase();
                    HandlePlayerInput(playerStringInput);
                    break;
                case 2:
                    Console.WriteLine("\nEnter a letter:");
                    char playerCharInput = currentPlayer.guessChar();
                    HandlePlayerInput(playerCharInput);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again");
                    PromptPlayerMove();
                    break;
            }
        }

        /// <summary>
        /// Processes player's letter selection
        /// </summary>
        /// <param name="input"></param>
        public void HandlePlayerInput(char input)
        {
            if (currentPhrase.CheckGuess(input))
            {
                currentPhrase.UpdateDashes(input);
                Console.WriteLine(currentPhrase.InProgressPuzzle);
            }
            else
            {
                currentGame.TryAgainMessage();
            }

            ContinueGame();
        }

        /// <summary>
        /// Processes player's guessed phrase
        /// </summary>
        /// <param name="input"></param>
        public void HandlePlayerInput(String input)
        {
            if (currentPhrase.CheckGuess(input))
            {
                currentPhrase.UpdateDashes(input);
                Console.WriteLine(currentPhrase.InProgressPuzzle);
                currentGame.ChangeGameStatus();
            }
            else
            {
                currentGame.TryAgainMessage();
                ContinueGame();
            }
        }

        /// <summary>
        /// Manage continuation of game
        /// </summary>
        public void ContinueGame()
        {
            DisplayGameMenu();
            DisplayPhrase();
            PromptPlayerMove();
        }

        public void InitiateGame()
        {
            currentGame.Start();
            currentPhrase.GetPuzzleReady();
            ContinueGame();
        }

        public void DisplayGameMenu()
        {
            Console.Write(@"
.-----.---------------------.
|Press|       Action        |
|-----|---------------------|
|  1  |    Guess the Phrase |
|  2  |    Select a Letter  |
|  3  |    Quit             |
'-----'---------------------'"
);
            Console.WriteLine();

        }

        public void DisplayPhrase()
        {
            Console.WriteLine("\nSolve the following phrase:");
            Console.WriteLine(currentPhrase.InProgressPuzzle);
        }

    }
}
