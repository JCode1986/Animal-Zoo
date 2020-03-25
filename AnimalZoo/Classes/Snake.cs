using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Snake : Reptile
    {
        public bool Slither { get; set; } = true;

        public string SnakeInfo()
        {
            return "\nSnake: A long limbless reptile which has no eyelids, a short tail, and jaws that are capable of considerable extension. Some snakes have a venomous bite.";
        }
    }
}
