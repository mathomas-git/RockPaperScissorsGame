﻿using RockPaperScissorsLibrary.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLibrary
{
    public interface IPlayer
    {
        Option GetOption(List<Option> opt, string language);
    }
}
