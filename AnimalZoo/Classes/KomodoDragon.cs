using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public class KomodoDragon : Lizard
    {
        public override int AverageWeightLBS { get; set; } = 190;
        public override decimal AverageMaxSpeedMPH { get; set; } = 12;
        public override string AverageLength { get; set; } = "8 ft.";
        public override string Diet { get; set; } = "Carnivore";

        public override string Ability()
        {
            return "*Venomous bite attack!";
        }

        public override string Eat()
        {
            return $"{Ability()} after knocking over prey with it's huge feet. *Eats*";
        }

        public override string Sound()
        {
            return "hissing";
        }

        public override string AnimalInfo()
        {
            return $"\nKomodo Dragon: {base.ReptileInfo()}{base.LizardInfo()}Fierce hunters they can eat very large prey, such as large water buffalo, deer, carrion, pigs and even humans.";
        }
    }
}
