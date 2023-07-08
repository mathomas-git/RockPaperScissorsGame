using RockPaperScissorsLibrary.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLibrary
{
    public class RockPaperScissorsGame : IRockPaperScissorsGame
    {
        private Player player1;
        private Player player2;
        private int roundsToWin;
        private int player1Score;
        private int player2Score;
        private List<Option> previousOptionList;
        LanguageManager languageManager = new LanguageManager();

        public RockPaperScissorsGame(Player player1, Player player2, int roundsToWin)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.roundsToWin = roundsToWin;
            this.player1Score = 0;
            this.player2Score = 0;
            this.previousOptionList = new List<Option>();
        }

        public void PlayGame(string language)
        {
            Console.WriteLine();
            while (player1Score < roundsToWin && player2Score < roundsToWin)
            {
                Option player1Option = player1.GetOption(previousOptionList, language);
                Option player2Option = player2.GetOption(previousOptionList, language);

                Console.WriteLine();
                
                Console.WriteLine($"{player1.Name}: {player1Option}");
                Console.WriteLine($"{player2.Name}: {player2Option}");
                Console.WriteLine();

                previousOptionList.Add(player1Option);
                previousOptionList.Add(player2Option);

                if (player1Option == player2Option)
                {
                    if (language == "en")
                    {
                        Console.WriteLine("It's a tie! Let's play another round.");
                    }
                    else
                    {
                        Console.WriteLine("Il y a égalité ! Jouons un autre tour.");
                    }
                }
                else if ((player1Option == Option.Rock && player2Option == Option.Scissors) ||
                         (player1Option == Option.Paper && player2Option == Option.Rock) ||
                         (player1Option == Option.Scissors && player2Option == Option.Paper) ||
                         (player1Option == Option.Flamethrower && player2Option == Option.Paper))
                {
                    if (language == "en")
                    {
                        Console.WriteLine($"{player1.Name} wins this round!");
                    }
                    else
                    {
                        Console.WriteLine($"{player1.Name} gagne ce tour.");
                    }
                    
                    player1Score++;
                }
                else
                {
                    if (language == "en")
                    {
                        Console.WriteLine($"{player2.Name} wins this round!");
                    }
                    else
                    {
                        Console.WriteLine($"{player2.Name} gagne ce tour.");
                    }
                    player2Score++;
                }

                Console.WriteLine();
            }

            if (language == "en")
            {
                Console.WriteLine($"{(player1Score == roundsToWin ? player1.Name : player2.Name)} wins the game!");
            }
            else
            {
                Console.WriteLine($"{(player1Score == roundsToWin ? player1.Name : player2.Name)} gagne le jeux!");
            }
        }

        public void StopGame(string language)
        {
            Console.ReadLine();
        }

     }

}
