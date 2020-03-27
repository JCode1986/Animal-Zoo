using Animal_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public class Pelican : IFly
    {
        public int WingSpan { get; set; } = 9;

        /// <summary>
        /// Pelican flap wings
        /// </summary>
        /// <returns>string</returns>
        public string FlapWings()
        {
            return "Pelican flaps wings";
        }

        /// <summary>
        /// Returns specific string based on speed given
        /// </summary>
        /// <param name="speed">in</param>
        /// <returns>string</returns>
        public string Land(int speed)
        {
            return speed > 50 ? "*Crash and burns*" : "perfect";
        }

        /// <summary>
        /// Pelican soaring through the sky.
        /// </summary>
        /// <returns>string</returns>
        public string Soar()
        {
            return "Pelican looking for food";
        }

        /// <summary>
        /// Pelican spreading wings.
        /// </summary>
        /// <returns>string</returns>
        public string SpreadWings()
        {
            return "Pelican spreads wings";
        }
    }
}
