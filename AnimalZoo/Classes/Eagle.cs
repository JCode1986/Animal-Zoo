using Animal_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public class Eagle : IFly
    {
        public int WingSpan { get; set; } = 9;

        public string FlapWings()
        {
            return "Eagle flaps wings";
        }

        public string Land(int speed)
        {
            return speed > 50 ? "Too fast" : "Just right.";
        }

        public string Soar()
        {
            return "just looking for some prey";
        }

        public string SpreadWings()
        {
            return "Eagle spread it's wings.";
        }
    }
}
