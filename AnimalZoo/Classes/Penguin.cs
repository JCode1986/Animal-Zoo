using Animal_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public class Penguin : ISwim
    {
        public string GoDiveUnderWater()
        {
            return "Going deeper and deerp into the abyss.";
        }

        public string GoSwim(int speed)
        {
            return speed > 25 ? "I am finding Nemo" : "Just keep swimming";
        }
    }
}
