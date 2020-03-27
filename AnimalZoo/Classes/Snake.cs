using Animal_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public abstract class Snake : IGreet, IDoRandomThing
    {
        /// <summary>
        /// Does a random thing base one irritation level. > 50 < triggers
        /// </summary>
        /// <param name="irritationLevel">int</param>
        /// <returns>string</returns>
        public string DoAnotherRandomThing(int irritationLevel)
        {
            return irritationLevel > 50 ? "*Slithers away*" : "*Hisses*";
        }

        /// <summary>
        /// Does a random thing.
        /// </summary>
        /// <returns>string</returns>
        public string DoRandomThing()
        {
            return "*Coils body*";
        }

        /// <summary>
        /// Magically introduce self to humans after given a name and age by user.
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="age">int</param>
        /// <returns>string</returns>
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
