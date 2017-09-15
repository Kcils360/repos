using System;
using System.Collections.Generic;
using System.Text;

namespace lab04gregoryBuildAZoo
{
    abstract class Rodent : Mamal
    {
        public string Scavenger ()
        {
            string scavenges = "Rodents are not predatory, they tend to scavange for food.";
            return scavenges;
        }

        
        /*scavenger
         * lives in burrows */
    }
}
