using System;
using System.Collections.Generic;
using System.Text;

namespace WheelOfFortuneV2
{
    public class Game
    {
        private bool isWon;
        private bool inProgress;
        public bool IsWon { get; set; }
        public bool InProgress { get; set; }

        //Game instantiation will be done in main method.

        public void Start()
        {
            inProgress = true;
            WelcomeMessage();
        }

        public void WelcomeMessage()
        {
            Console.WriteLine(@"
 __          __  _                            _         __          ___               _    ____   __   ______         _                    
 \ \        / / | |                          | |        \ \        / / |             | |  / __ \ / _| |  ____|       | |                   
  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___    \ \  /\  / /| |__   ___  ___| | | |  | | |_  | |__ ___  _ __| |_ _   _ _ __   ___ 
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \    \ \/  \/ / | '_ \ / _ \/ _ \ | | |  | |  _| |  __/ _ \| '__| __| | | | '_ \ / _ \
    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) |    \  /\  /  | | | |  __/  __/ | | |__| | |   | | | (_) | |  | |_| |_| | | | |  __/
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/      \/  \/   |_| |_|\___|\___|_|  \____/|_|   |_|  \___/|_|   \__|\__,_|_| |_|\___|
");
        }

        public void WinningMessage()
        {
            Console.WriteLine(@"

 /$$     /$$                           /$$      /$$ /$$           /$$
|  $$   /$$/                          | $$  /$ | $$|__/          | $$
 \  $$ /$$/   /$$$$$$  /$$   /$$      | $$ /$$$| $$ /$$ /$$$$$$$ | $$
  \  $$$$/   /$$__  $$| $$  | $$      | $$/$$ $$ $$| $$| $$__  $$| $$
   \  $$/   | $$  \ $$| $$  | $$      | $$$$_  $$$$| $$| $$  \ $$|__/
    | $$    | $$  | $$| $$  | $$      | $$$/ \  $$$| $$| $$  | $$    
    | $$    |  $$$$$$/|  $$$$$$/      | $$/   \  $$| $$| $$  | $$ /$$
    |__/     \______/  \______/       |__/     \__/|__/|__/  |__/|__/
                                                                     

");


        }

        public void TryAgainMessage()
        {
            Console.WriteLine(@"

 _____                  _                  _                 
/__   \ _ __  _   _    /_\    __ _   __ _ (_) _ __           
  / /\/| '__|| | | |  //_\\  / _` | / _` || || '_ \          
 / /   | |   | |_| | /  _  \| (_| || (_| || || | | | _  _  _ 
 \/    |_|    \__, | \_/ \_/ \__, | \__,_||_||_| |_|(_)(_)(_)
              |___/          |___/                           

");
        }

        public void ChangeGameStatus()
        {
            isWon = !isWon;
            WinningMessage();
        }



    }
}
