using System;

namespace WheelOfFortuneV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Phrase phrase = new Phrase("Leap into Leap");
            Player player = new Player("George");
            GameManager gameManager = new GameManager(game, phrase, player);

            gameManager.InitiateGame();
        }
    }
}
