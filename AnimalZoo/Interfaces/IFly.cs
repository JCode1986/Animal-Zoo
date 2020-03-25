using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Interfaces
{
    interface IFly
    {
        int WingSpan { get; set; }
        string SpreadWings();
        string FlapWings();
        string Soar();
        string Land(int speed);
    }
}
