using System;
using System.Collections.Generic;
using System.Text;

namespace lab04gregoryBuildAZoo
{
    class MainCoon : Feline
    {
        public bool MajesticAF { get; set; } //set to true

        public void HouseBroken ()
        {
            Console.WriteLine("The majestic Main Coon lives in your house.");
        }
    }
}
