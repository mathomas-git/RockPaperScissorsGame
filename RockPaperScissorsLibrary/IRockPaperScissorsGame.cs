using RockPaperScissorsLibrary.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLibrary
{
    public interface IRockPaperScissorsGame
    {
        void PlayGame(string language);
        void StopGame(string language);
    }
}
