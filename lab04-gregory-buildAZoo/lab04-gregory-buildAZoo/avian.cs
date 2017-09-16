using System;
using System.Collections.Generic;
using System.Text;

namespace lab04gregoryBuildAZoo
{
    abstract class Avian : Animal
    {
        abstract public int Wings();

        
        public void Mouth()
        {
            Console.WriteLine("Birds have beaks for mouths.");
        }

        public new int Legs ()
        {
            int legs = 2;
            return legs;
        }

      

    }
}
