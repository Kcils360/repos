using System;
using System.Collections.Generic;
using System.Text;

namespace lab04gregoryBuildAZoo
{
    abstract class Mamal : Animal
    {
        public string Birth ()
        {
            string birthType = "Mamals all give birth to live, fully formed offspring";
            return birthType;
        }

        public bool Hair ()
        {
            bool hair = true;
            return hair;
        }

        public bool Mammories
        {
            get
            {
                return true;
            }
            set
            {

            }
        } 

    }
}
