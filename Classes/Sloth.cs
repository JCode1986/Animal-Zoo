using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Sloth : TreeDweller
    {
        public override int AverageWeightLBS { get; set; } = 14;
        public override decimal AverageMaxSpeedMPH { get; set; } = 0.15M;
        public override string AverageLength { get; set; } = "2.5 feet";

        public override string Diet { get; set; } = "Herbivore";

        public override string Ability()
        {
            return "*ZzZzZzZzZz*";
        }

        public override string Sound()
        {
            return "*squeaking sound*";
        }

        public override string Eat()
        {
            return "*Slowly reaches out for a leaf*.... approximately 6 minutes later, *munches on leaf*";
        }
        public string SlothInfo()
        {
            return $"\nSloth:{base.MammalInfo()}{base.TreeDwellerInfo()}\nSluggish tree dweller.Very slow.....";
        }
    }
}
