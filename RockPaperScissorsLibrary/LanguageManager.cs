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

        public string GetPlayModeDescription()
        {
            switch (currentLanguage)
            {
                case "en":
                    return "Please Enter 1 to play with two players\nEnter 2 to play with the Computer";
                case "fr":
                    return "SVP Entrer 1 pour jouer avec 2 Joeurs\nEntrer 2 pour jouer avec le Computer";
                default:
                    return "Unsupported.";
            }
        }
        public string EnterPlayer1Name()
        {
            switch (currentLanguage)
            {
                case "en":
                    return "Please enter the name for player No 1: ";
                case "fr":
                    return "SVP entrer le nom du joueur No 1: ";
                default:
                    return "Unsupported.";
            }
        }
        public string EnterPlayer2Name()
        {
            switch (currentLanguage)
            {
                case "en":
                    return "Please enter the name for player No 2: ";
                case "fr":
                    return "SVP entrer le nom du joueur No 2: ";
                default:
                    return "Unsupported.";
            }
        }
    }

}
