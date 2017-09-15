using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game about me!");
            Console.WriteLine("First, what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Thank you {userName}, let's begin.");
            Console.Read();
            CityBorn();
            KillForPizza();
            NumberOfToppings();
        }

        static void CityBorn()
        {
            Console.WriteLine("Was I born in Washington?");
            Console.Read();
            string city = Console.ReadLine().ToLower();
            //Console.Read();

            if (city == "yes" || city == "y")
            {
                Console.WriteLine("Nope!  I was born in Colorado! In Denver.");
                Console.Read();

            } else if (city == "no" || city == "n")
            {
                Console.WriteLine("Correct! I was born in Denver, Colorado.");
                Console.Read();

            }else
            {
                Console.WriteLine("Please answer with 'yes' or 'no'.");
                CityBorn();
            }
        }

        static void KillForPizza()
        {
            Console.WriteLine("Would I kill for some pizza?");
            Console.Read();

            string kill = Console.ReadLine().ToLower();
            //Console.Read();

            if (kill == "yes" || kill == "y")
            {
                Console.WriteLine("Um, no, murder is illigal! But I really do want some pizza right now.");
                Console.Read();

            }else if (kill == "no" || kill == "n")
            {
                Console.WriteLine("Right, because murder is illigal, but I really do want some pizza right now.");
                Console.Read();

            }else
            {
                Console.WriteLine("Please answer with 'yes' or 'no'.");
                KillForPizza();
            }
        }

        static void NumberOfToppings()
        {

            int guesses = 0;
            do
            {
            Console.WriteLine("How many toppings do I prefer on my pizza?");
                Console.Read();
            int numToppings = Console.Read();

                if (numToppings < 4)
                {
                    Console.WriteLine("That's almost plain! More please!");
                    Console.Read();
                    guesses++;

                }
                if (numToppings > 4)
                {
                    Console.WriteLine("Hey, don't overload the pie! Try again.");
                    Console.Read();
                    guesses++;

                }
                if (numToppings == 4)
                {
                    Console.WriteLine("Bingo, I think 4 toppings in optimal pizza yummage!");
                    Console.Read();
                    break;
                }
                else
                {
                    Console.WriteLine("Please press a number.");
                    Console.Read();
                    guesses++;
                }
            }
            while (guesses < 6);
        }
    }
}
