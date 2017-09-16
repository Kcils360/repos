using System;
using System.Collections.Generic;
using System.Text;

namespace lab04gregoryBuildAZoo
{
    abstract class Feline : Mamal
    {
        abstract public void Predatory();

        public bool RetractableClaws()
        {
            return true;
        }

    }
}
