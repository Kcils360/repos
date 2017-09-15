using System;

namespace lab04gregoryBuildAZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Eagle uncleSam = new Eagle();

            uncleSam.MajesticAF();
            Console.Write($"Eagles have {uncleSam.Legs()} legs");
            Console.WriteLine();

            MainCoon josieCat = new MainCoon();

            josieCat.HouseBroken();
            Console.WriteLine($"Josi Cat has {josieCat.Legs()} legs");
            Console.WriteLine(josieCat.Birth());
            Console.WriteLine();

            Swallow montyPython = new Swallow();
            Console.WriteLine("What is the avreage airspeed velocity of a swallow carrying a coconut?");
            Console.WriteLine(montyPython.LadenAirSpeed());
            Console.WriteLine($"Swallows are animals, which all have {montyPython.Eyes()} eyes");
            Console.WriteLine();

            PeregrineFalcon falcor = new PeregrineFalcon();
            falcor.MaximumAltitude = 350;
            Console.WriteLine($"A falcon's maximum altitude is {falcor.MaximumAltitude} feet, and can fly at {falcor.UnladenAirSpeed()} mph. ");

            Console.Read();
        }
    }
}
