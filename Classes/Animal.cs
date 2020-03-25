using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Animal
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
