﻿using Roshambo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    internal class HumanPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        { return new Roshambo(); } 
    }
}  