using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public abstract class Reptile : Animal
    {
        public bool HasScales { get; set; } = true;
        public bool ColdBlooded { get; set; } = true;
        public bool LayEggs { get; set; } = true;

        public string ReptileInfo()
        {
            return "\nReptile: A vertebrate animal of a class that includes snakes, lizards, crocodiles, turtles, and tortoises.They are distinguished by having a dry scaly skin and typically laying soft-shelled eggs on land.";
        }
    }
}
