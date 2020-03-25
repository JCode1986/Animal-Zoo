using Animal_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public abstract class Snake : IGreet, IDoRandomThing
    {
        public string DoAnotherRandomThing(int irritationLevel)
        {
            return irritationLevel > 50 ? "*Slithers away*" : "*Hisses*";
        }

        public string DoRandomThing()
        {
            return "*Coils body*";
        }

        public string MagicallyIntroduceSelfToHumans(string name, int age)
        {
            return $"SSSSSalutationsss! My name isssss {name}, and I am {age} year(sssssss) old. SSSSSee you later.";
        }


        //from abstract class

        /*public bool Slither { get; set; } = true;

        public string SnakeInfo()
        {
        return "\nSnake: A long limbless reptile which has no eyelids, a short tail, and jaws that are capable of considerable extension. Some snakes have a venomous bite.";
        }*/
    }
}
