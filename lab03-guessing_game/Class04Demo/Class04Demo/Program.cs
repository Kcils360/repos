using System;

namespace Class04Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int test = 10;

            //this is an object
            Graduation dotNET401d1 = new Graduation("red", 10, "black");

            dotNET401d1.BadDecisions();
            //this is an object
            //Party miyasParty = new Party(2000, 20);

            //miyasParty.PartyBudget();
            //miyasParty.Games();


            Graduation collegeGrad = new Graduation("Green", 10, "Blue");

            collegeGrad.Games();
            collegeGrad.Budget = 200;
            collegeGrad.PartyBudget();


            Console.Read();
        }
    }
}
