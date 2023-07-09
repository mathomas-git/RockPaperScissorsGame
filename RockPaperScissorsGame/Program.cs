using RockPaperScissorsLibrary;
using RockPaperScissorsLibrary.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roundsToWin = 3;
            LanguageManager languageManager = new LanguageManager();
            string language = "en";

            string input = GetLanguage();

            if (input == "1")
            {
                languageManager.SetLanguage("en");
                language = "en";
            }
            else if (input == "2")
            {
                languageManager.SetLanguage("fr");
                language = "fr";
            }
      
            string greeting = languageManager.GetGreeting();
            Console.WriteLine(greeting);
            Console.WriteLine("Language: "+language.ToUpper());
            AddLine();
            Console.WriteLine(languageManager.GetPlayModeDescription());
            int playMode = Convert.ToInt32(ChoiceValidation());
            if (playMode == 1)
                if (language == "en")
                {
                    Console.WriteLine("Game Mode Chose: 2 PLAYERS");
                }
                else
                {
                    Console.WriteLine("Mode de Jeux Choisi: 2 Joeurs"); 
                }
            else
                 if (language == "en")
                {
                    Console.WriteLine("Game Mode Chose : WITH COMPUTER");
                }
                else
                {
                    Console.WriteLine("Mode de Jeux Choisi : AVEC ORDINATEUR");
                }
           
            Console.Write(languageManager.EnterPlayer1Name());
            string player1Name = Console.ReadLine();
            Player player1 = new Player(PlayerType.Human, player1Name);
            Player player2 = new Player();
            string player2Name = "";

            switch (playMode)
            {
                case 1:
                    AddLine();
                    Console.Write(languageManager.EnterPlayer2Name());
                    player2Name = Console.ReadLine();
                    player2 = new Player(PlayerType.Human, player2Name);
                    break;
                default:
                    break;
            }

            //Create a new instance of RockPaperScissorsGame
            RockPaperScissorsGame game = new RockPaperScissorsGame(player1, player2, roundsToWin);
            //Start the Game
            game.PlayGame(language);
            //Stop the Game
            game.StopGame(language);

        }
        static string GetLanguage()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Select a language:");
            Console.WriteLine("1 - English");
            Console.WriteLine("2 - French");
            Console.WriteLine("=================================");

            return ChoiceValidation();  
        }

        static string ChoiceValidation()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 2)
                {
                    return choice.ToString();
                }

                Console.WriteLine("Invalid input. Please enter a valid choice (1-2):");
            }
        }

        static void AddLine()
        {
            Console.WriteLine("");
        }

    }
}
