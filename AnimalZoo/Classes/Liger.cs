using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public class Liger : Feline
    {
        public override int AverageWeightLBS { get; set; } = 1000;
        public override decimal AverageMaxSpeedMPH { get; set; } = 50;
        public override string AverageLength { get; set; } = "10 feet";

        public override string Diet { get; set; } = "Carnivore";

        public override string Ability()
        {
            return "*cuddle*";
        }

        public override string Sound()
        {
            return "*Roooaaaaaarrrrrr!!!*";
        }

        public override string Eat()
        {
            return $"{base.Hunt()}. *spots a gazelle* {Sound()} *pounce and eats*";
        }

        public string LigerInfo()
        {
            return $"Liger:{base.MammalInfo()}{base.FelineInfo()}The liger is a hybrid offspring of a male lion and a female tiger.";
        }
    }
}
