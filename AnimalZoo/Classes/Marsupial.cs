using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public abstract class Marsupial : Mammal
    {
        public virtual bool HasPouch { get; set; } = true;

        /// <summary>
        /// Returns a string of what a marsupial is defined as.
        /// </summary>
        /// <returns></returns>
        public string MarsupialInfo()
        {
            return "\nMarsupial: A marsupial is a mammal that raises its newborn offspring inside an external pouch at the front or underside of their bodies.";
        }
    }
}
