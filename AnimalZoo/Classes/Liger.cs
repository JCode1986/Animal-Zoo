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

        /// <summary>
        /// Returns string of Liger's ability.
        /// </summary>
        /// <returns>string</returns>
        public override string Ability()
        {
            return "*cuddle*";
        }

        /// <summary>
        /// Returns string of Liger's sound.
        /// </summary>
        /// <returns>string</returns>
        public override string Sound()
        {
            return "*Roooaaaaaarrrrrr!!!*";
        }

        /// <summary>
        /// Returns string of how Liger's eat.
        /// </summary>
        /// <returns>string</returns>
        public override string Eat()
        {
            return $"{base.Hunt()}. *spots a gazelle* {Sound()} *pounce and eats*";
        }

        /// <summary>
        /// Returns string of Liger's information.
        /// </summary>
        /// <returns></returns>
        public override string AnimalInfo()
        {
            return $"Liger:{base.MammalInfo()}{base.FelineInfo()}The liger is a hybrid offspring of a male lion and a female tiger.";
        }
    }
}
