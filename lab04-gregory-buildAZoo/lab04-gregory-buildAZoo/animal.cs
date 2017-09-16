using System;
using System.Collections.Generic;
using System.Text;

namespace lab04gregoryBuildAZoo
{
    abstract class Animal
    {
        abstract public int Eyes();


        public int Legs ()
        {
            int legs = 4;
            return legs;
        }

        public string Sound()
        {
            return null;
        }

        public bool Tail ()
        {
            bool tail = true;
            return tail;
        }
    }
}
