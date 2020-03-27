using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    //Mammal can be astract; other classes derived from Mammal
    public abstract class Mammal : Animal // Show Inheritance through the colon (:) symbol
    {
        public bool HasFur { get; set; } = true;

        public bool HasTail { get; set; } = true;

        /// <summary>
        /// Returns string of what a mammal is defined as.
        /// </summary>
        /// <returns>string</returns>
        public string MammalInfo()
        {
            return "\nMammal: a warm-blooded vertebrate animal of a class that is distinguished by the possession of hair or fur, the secretion of milk by females for the nourishment of the young, and (typically) the birth of live young.";
        }

        /// <summary>
        /// Returns a specific string based on speed given
        /// </summary>
        /// <param name="speed">int</param>
        /// <returns>string</returns>
        public virtual string MammalFastOrSlow(decimal speed)
        {
            return speed < 5 ? "Slow" : "Fast";
        }
    }
}
