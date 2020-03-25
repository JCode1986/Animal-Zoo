using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    abstract class Marsupial : Mammal
    {
        public virtual bool HasPouch { get; set; } = true;

        public string MarsupialInfo()
        {
            return "\nMarsupial: A marsupial is a mammal that raises its newborn offspring inside an external pouch at the front or underside of their bodies.";
        }
    }
}
