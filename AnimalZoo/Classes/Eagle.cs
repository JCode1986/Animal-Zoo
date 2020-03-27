using Animal_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public class Eagle : IFly
    {
        public int WingSpan { get; set; } = 7;

        /// <summary>
        /// Flap wings for eage
        /// </summary>
        /// <returns>string</returns>
        public string FlapWings()
        {
            return "Eagle flaps wings";
        }

        /// <summary>
        /// Method that takes in a speed as an argument and returns specific string according to speed.
        /// </summary>
        /// <param name="speed">int</param>
        /// <returns>string</returns>
        public string Land(int speed)
        {
            return speed > 50 ? "Too fast" : "Just right.";
        }

        /// <summary>
        /// Return string of eagle soaring.
        /// </summary>
        /// <returns>string</returns>
        public string Soar()
        {
            return "just looking for some prey";
        }

        /// <summary>
        /// Return string of eagle spreading wings
        /// </summary>
        /// <returns>string</returns>
        public string SpreadWings()
        {
            return "Eagle spread it's wings.";
        }
    }
}
