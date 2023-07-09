using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLibrary
{
    public class LanguageManager
    {
        private string currentLanguage;

        public void SetLanguage(string language)
        {
            currentLanguage = language;
        }

        public string GetGreeting()
        {
            switch (currentLanguage)
            {
                case "en":
                    return "Welcome to Rock-Paper-Scissors Game!";
                case "fr":
                    return "Bienvenue dans le jeux Roche-Papier-Ciseaux!";
                default:
                    return "Unsupported language.";
            }
        }

        public string GetPlayModeTitle()
        {
            switch (currentLanguage)
            {
                case "en":
                    return "Please Enter: \n 1- To play with two players\n 2- To play with the Computer";
                case "fr":
                    return "SVP Entrer\n 1- Pour jouer avec 2 Joeurs\n 2- Pour jouer avec l'Ordinateur";
                default:
                    return "Unsupported.";
            }
        }

        public string GetPlayModeDescription()
        {
            switch (currentLanguage)
            {
                case "en":
                    return "Select Game Mode:\n 1- To play with two players\n 2- To play with the Computer";
                case "fr":
                    return "Choisir Mode de Jeu:\n 1- Pour jouer avec 2 Joeurs\n 2- Pour jouer avec l'Ordinateur";
                default:
                    return "Unsupported.";
            }
        }

        public string EnterPlayer1Name()
        {
            switch (currentLanguage)
            {
                case "en":
                    return "Please enter the name for PLAYER No 1: ";
                case "fr":
                    return "SVP entrer le nom du JOUEUR No 1: ";
                default:
                    return "Unsupported.";
            }
        }
        public string EnterPlayer2Name()
        {
            switch (currentLanguage)
            {
                case "en":
                    return "Please enter the name for PLAYER No 2: ";
                case "fr":
                    return "SVP entrer le nom du JOUEUR No 2: ";
                default:
                    return "Unsupported.";
            }
        }
    }

}
