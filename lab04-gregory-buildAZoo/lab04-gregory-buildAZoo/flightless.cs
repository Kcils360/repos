using System;
using System.Collections.Generic;
using System.Text;

namespace lab04gregoryBuildAZoo
{
    abstract class Flightless : Avian
    {
        public bool Flight { get; set; } //set to false

        public int GroundSpeed { get; set; }
    }
}
