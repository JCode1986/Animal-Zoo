using Animal_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public class Sloth : IGreet, IDoRandomThing
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       
        /// <summary>
        /// Sloth does a random thing
        /// </summary>
        /// <returns></returns>
        public string DoRandomThing()
        {

            return "*Throws a twig into the lake from tree top*";
        }

        /// <summary>
        /// Returns a specific string based on irritation level as an argument
        /// </summary>
        /// <param name="irritationLevel"></param>
        /// <returns>string</returns>
        public string DoAnotherRandomThing(int irritationLevel)
        {
            return irritationLevel > 50 ? "*Farts" : "*Slowly scratches face";
        }

        /// <summary>
        /// Magically introduce self to humans after given a name and age
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="age">int</param>
        /// <returns></returns>
        public string MagicallyIntroduceSelfToHumans(string name, int age)
        {
            return $"Hello there good sir or maam. I am a sloth, and my name is {name}, and I am {age} year(s) old. Nice to meet you!";
        }
    }
    /* class Sloth : TreeDweller
     {
         public override int AverageWeightLBS { get; set; } = 14;
         public override decimal AverageMaxSpeedMPH { get; set; } = 0.15M;
         public override string AverageLength { get; set; } = "2.5 feet";

         public override string Diet { get; set; } = "Herbivore";

         public override string Ability()
         {
             return "*ZzZzZzZzZz*";
         }

         public override string Sound()
         {
             return "*squeaking sound*";
         }

         public override string Eat()
         {
             return "*Slowly reaches out for a leaf*.... approximately 6 minutes later, *munches on leaf*";
         }
         public string SlothInfo()
         {
             return $"\nSloth:{base.MammalInfo()}{base.TreeDwellerInfo()}\nSluggish tree dweller.Very slow.....";
         }*/
}
