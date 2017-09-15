using System;
using System.Collections.Generic;
using System.Text;

namespace lab04gregoryBuildAZoo
{
    class PeregrineFalcon : Flying
    {
        public new int UnladenAirSpeed()
        {
            int airSpeed = 240;
            return airSpeed;
        }
    }
}
