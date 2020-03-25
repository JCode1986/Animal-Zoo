using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public abstract class Animal
    {
        public abstract int AverageWeightLBS { get; set; }
        public abstract decimal AverageMaxSpeedMPH { get; set; }
        public abstract string AverageLength { get; set; }

        public abstract string Diet { get; set; }

        public abstract string Sound();
        public abstract string Ability();

        public abstract string Eat();

    }
}
