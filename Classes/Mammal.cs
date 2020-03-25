using System;
using System.Collections.Generic;
using System.Text;
using Zoo;

namespace Zoo.Classes
{
    //Mammal can be astract; other classes derived from Mammal
    abstract class Mammal : Animal // Show Inheritance through the colon (:) symbol
    {
        public bool HasFur { get; set; } = true;

        public bool HasTail { get; set; } = true;
        public string MammalInfo()
        {
            return "\nMammal: a warm-blooded vertebrate animal of a class that is distinguished by the possession of hair or fur, the secretion of milk by females for the nourishment of the young, and (typically) the birth of live young.";
        }

        public virtual string MammalFastOrSlow(decimal speed)
        {
            return speed < 5 ? "Slow" : "Fast";
        }
    }
}
