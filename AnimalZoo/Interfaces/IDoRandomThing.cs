using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Zoo.Interfaces
{
    interface IDoRandomThing
    {
        string DoRandomThing();
        
        /// <summary>
        /// Does a random thing based on irritation level
        /// </summary>
        /// <param name="irritationLevel">int</param>
        /// <returns>string</returns>
        string DoAnotherRandomThing(int irritationLevel);

    }
}
