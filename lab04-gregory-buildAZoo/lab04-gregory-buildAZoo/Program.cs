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

            Console.Read();
        }
    }
}
