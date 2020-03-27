using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public abstract class Feline : Mammal
    {
        public virtual bool HasFangs { get; set; } = true;

        public virtual bool HasRetractableClaws { get; set; } = true;

        /// <summary>
        /// Returns string of what a feline is.
        /// </summary>
        /// <returns>string</returns>
        public virtual string FelineInfo()
        {
            return "\nFeline: Member of the cat family.\n";
        }

        /// <summary>
        /// Returns string on how felines hunt
        /// </summary>
        /// <returns>string</returns>
        public virtual string Hunt()
        {
            return "*Crouches behind bush, and stealthily sneaks up on prey*";
        }
    }
}
