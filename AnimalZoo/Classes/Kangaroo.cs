using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public class Kangaroo : Marsupial
    {
        public override int AverageWeightLBS { get; set; } = 85;
        public override decimal AverageMaxSpeedMPH { get; set; } = 44;
        public override string AverageLength { get; set; } = "9.2 feet";
        public override string Diet { get; set; } = "Herbivore";

        /// <summary>
        /// Returns string of kangaroo's ability
        /// </summary>
        /// <returns>string</returns>
        public override string Ability()
        {
            return "Jump!";
        }

        /// <summary>
        /// Returns string of kangaroo's sound.
        /// </summary>
        /// <returns>string</returns>
        public override string Sound()
        {
            return "*loud 'coughing' growls*";
        }

        /// <summary>
        /// Returns string of how kangaroo's eat
        /// </summary>
        /// <returns>string</returns>
        public override string Eat()
        {
            return $"{Sound()}*Pulls flowers out of pouch and start eating*";
        }

        /// <summary>
        /// Returns string of a kangaroo information.
        /// </summary>
        /// <returns></returns>
        public override string AnimalInfo()
        {
            return $"\nKangaroo:{base.MammalInfo()}{base.MarsupialInfo()}\nThe kangaroo is a marsupial from the family Macropodidae (macropods, meaning 'large foot'). In common use the term is used to describe the largest species from this family, especially the red kangaroo, antilopine kangaroo, eastern grey kangaroo, and western grey kangaroo. Kangaroos are indigenous to Australia.";
        }
    }
}
