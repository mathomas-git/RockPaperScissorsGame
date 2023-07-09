using RockPaperScissorsLibrary.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLibrary
{

    public class Player : IPlayer
    {
        public PlayerType Type { get; set; }
        public string Name { get; set; }

        //Default Constructor For Computer Player
        public Player()
        {
            Type = PlayerType.Computer;
            Name = "Computer";
        }
        public Player(PlayerType type, string name)
        {
            Type = type;
            Name = name;
        }

        public Option GetOption(List<Option> previousOptionList, string language)
        {
            if (Type == PlayerType.Human)
            {
                if (language == "en")
                {
                    Console.WriteLine($"{Name}, please select an option:");
                }
                else
                {
                    Console.WriteLine($"{Name}, veuillez choisir une option:");
                }
                
                DisplayOptions(language);

                if (language == "en")
                {
                    Console.Write("Enter your choice (1 - 4): ");
                }
                else
                {
                    Console.Write("Entrer votre choix (1 - 4): ");
                }
                
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
                    {
                        return (Option)(choice - 1);
                    }
                    if (language == "en")
                    {
                        Console.WriteLine("Invalid input. Please enter a valid option (1 - 4):");
                    }
                    else
                    {
                        Console.WriteLine("Saisie invalide. Veuillez entrer une option valide (1 - 4):");
                    }
                    
                }
            }
            else
            {
                Option computerOption;

                if (previousOptionList.Count == 0)
                {
                    computerOption = GetComputerRandomOption();
                }
                else
                {
                    Option previousOption = previousOptionList[previousOptionList.Count - 1];
                    computerOption = GetComputerBehaviorOption(previousOption);
                }

                Console.WriteLine("");
                return computerOption;
            }
            
        }

        private Option GetComputerRandomOption()
        {
            Random random = new Random();
            int randomIndex = random.Next(1, Enum.GetValues(typeof(Option)).Length);
            return (Option)randomIndex;
        }

        private Option GetComputerBehaviorOption(Option option)
        {

            if (option == Option.Rock)
            {
                return Option.Paper;
            }
            else if (option == Option.Paper)
            {
                return Option.Scissors;
            }
            else if (option == Option.Scissors)
            {
                return Option.Rock;
            }
            else
            {
                return GetComputerRandomOption();
            }
        }

        private void DisplayOptions(string language)
        {
            if (language == "en")
            {
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.WriteLine("4. Flamethrower");
            }
            else
            {
                Console.WriteLine("1. Roche");
                Console.WriteLine("2. Papier");
                Console.WriteLine("3. Ciseaux");
                Console.WriteLine("4. Lance-flamme");
            }

        }

    }
}
