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

        /// <summary>
        /// Returns string of komodo dragon's ability
        /// </summary>
        /// <returns></returns>
        public override string Ability()
        {
            return "*Venomous bite attack!";
        }

        /// <summary>
        /// Returns string of how komodo dragon's eat
        /// </summary>
        /// <returns>string</returns>
        public override string Eat()
        {
            return $"{Ability()} after knocking over prey with it's huge feet. *Eats*";
        }

        /// <summary>
        /// Returns string of komodo dragon's sound.
        /// </summary>
        /// <returns>string</returns>
        public override string Sound()
        {
            return "hissing";
        }

        /// <summary>
        /// Returns string of komodo dragon's information.
        /// </summary>
        /// <returns>string</returns>
        public override string AnimalInfo()
        {
            return $"\nKomodo Dragon: {base.ReptileInfo()}{base.LizardInfo()}Fierce hunters they can eat very large prey, such as large water buffalo, deer, carrion, pigs and even humans.";
        }
    }
}
