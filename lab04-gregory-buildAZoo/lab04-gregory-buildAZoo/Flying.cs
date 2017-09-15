using System;
using System.Collections.Generic;
using System.Text;

namespace lab04gregoryBuildAZoo
{
    abstract class Flying : Avian
    {
        public int MaximumAltitude { get; set; }

        public string LadenAirSpeed { get; set; }

        public int UnladenAirSpeed { get; set; }
    }
}
