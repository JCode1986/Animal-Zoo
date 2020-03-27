using Animal_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public class Penguin : ISwim
    {
        /// <summary>
        /// Returns string of penguin diving deer under water.
        /// </summary>
        /// <returns></returns>
        public string GoDiveUnderWater()
        {
            return "Going deeper and deerp into the abyss.";
        }

        /// <summary>
        /// Returns a specific string after given a speed
        /// </summary>
        /// <param name="speed">int</param>
        /// <returns>string</returns>
        public string GoSwim(int speed)
        {
            return speed > 25 ? "I am finding Nemo" : "Just keep swimming";
        }
    }
}
