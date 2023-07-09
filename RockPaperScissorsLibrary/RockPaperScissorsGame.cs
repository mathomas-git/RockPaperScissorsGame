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
            AddLine();
            while (player1Score < roundsToWin && player2Score < roundsToWin)
            {
                Option player1Option = player1.GetOption(previousOptionList, language);
                Option player2Option = player2.GetOption(previousOptionList, language);
                AddLine();
                Console.WriteLine($"{player1.Name}: {player1Option}");
                Console.WriteLine($"{player2.Name}: {player2Option}");
                AddLine();

                previousOptionList.Add(player1Option);
                previousOptionList.Add(player2Option);

                if (player1Option == player2Option)
                {
                    if (language == "en")
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("It's a tie! Let's play another round.");
                        Console.WriteLine("=================================");
                    }
                    else
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("Il y a égalité ! Jouons un autre tour.");
                        Console.WriteLine("=================================");
                    }
                }
                else if ((player1Option == Option.Rock && player2Option == Option.Scissors) ||
                         (player1Option == Option.Paper && player2Option == Option.Rock) ||
                         (player1Option == Option.Scissors && player2Option == Option.Paper) ||
                         (player1Option == Option.Flamethrower && player2Option == Option.Paper))
                {
                    player1Score++;
                    if (language == "en")
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine($"{player1.Name} wins this round.");
                        Console.WriteLine("Game Score:");
                        Console.WriteLine($"{player1.Name} :" + player1Score);
                        Console.WriteLine($"{player2.Name} :" + player2Score);
                        Console.WriteLine("=================================");
                    }
                    else
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine($"{player1.Name} gagne ce tour." );
                        Console.WriteLine("Score de Jeux:");
                        Console.WriteLine($"{player1.Name} :" + player1Score);
                        Console.WriteLine($"{player2.Name} :" + player2Score);
                        Console.WriteLine("=================================");
                    }   
                }
                else
                {
                    player2Score++;
                    if (language == "en")
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine($"{player2.Name} wins this round.");
                        Console.WriteLine("Game Score:");
                        Console.WriteLine($"{player1.Name} :" + player1Score);
                        Console.WriteLine($"{player2.Name} :" + player2Score);
                        Console.WriteLine("=================================");
                    }
                    else
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine($"{player2.Name} gagne ce tour." );
                        Console.WriteLine("Score de Jeux:");
                        Console.WriteLine($"{player1.Name} :" + player1Score);
                        Console.WriteLine($"{player2.Name} :" + player2Score);
                        Console.WriteLine("=================================");
                    }
                }
            }

            if (language == "en")
            {
                Console.WriteLine("=================================");
                Console.WriteLine("GAME OVER!!!");
                Console.WriteLine($"{(player1Score == roundsToWin ? player1.Name : player2.Name)} wins the game!");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("=================================");
                Console.WriteLine("FIN DU JEU!!!");
                Console.WriteLine($"{(player1Score == roundsToWin ? player1.Name : player2.Name)} gagne le jeux!");
                Console.WriteLine("=================================");
            }
        }

        public void StopGame(string language)
        {
            if (language == "en")
            {
                AddLine();
                Console.WriteLine("Press Enter to quit the Game!");
            }
            else
            {
                AddLine();
                Console.WriteLine("Presser la touche Enter pour sortir du Jeux");
            }
            Console.ReadLine();
        }

        private void AddLine()
        {
            Console.WriteLine("");
        }
    }
}
