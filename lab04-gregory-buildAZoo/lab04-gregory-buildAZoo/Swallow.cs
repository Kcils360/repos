using System;
using System.Collections.Generic;
using System.Text;

namespace lab04gregoryBuildAZoo
{
    class Swallow : Flying
    {
        public new int UnladenAirSpeed()
        {
            int airSpeed = 24;
            return airSpeed;
        }

        public new string LadenAirSpeed()
        {
            string airSpeed = "African or European?";
            return airSpeed;
        }
        
    }
}
