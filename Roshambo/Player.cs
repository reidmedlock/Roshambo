using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{   
    internal abstract class Player
    { 
        public string name { get ; set; }  
        public Roshambo Value { get; set; }

        public abstract Roshambo GenerateRoshambo();
        

    }
}
     