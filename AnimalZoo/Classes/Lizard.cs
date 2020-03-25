using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public abstract class Lizard : Reptile
    {
        public bool HasTail { get; set; } = true;

        public string LizardInfo()
        {
            return $"\nLizard: a reptile that typically has a long body and tail, four legs, movable eyelids, and a rough, scaly, or spiny skin.";
        }
    }
}
