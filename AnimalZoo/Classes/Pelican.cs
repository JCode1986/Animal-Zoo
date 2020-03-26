using Animal_Zoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Classes
{
    public class Pelican : IFly
    {
        public int WingSpan { get; set; } = 9;

        public string FlapWings()
        {
            return "Pelican flaps wings";
        }

        public string Land(int speed)
        {
            return speed > 50 ? "*Crash and burns*" : "perfect";
        }

        public string Soar()
        {
            return "Pelican looking for food";
        }

        public string SpreadWings()
        {
            return "Pelican spreads wings";
        }
    }
}
