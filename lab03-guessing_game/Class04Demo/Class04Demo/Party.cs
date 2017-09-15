using System;
using System.Collections.Generic;
using System.Text;

namespace Class04Demo
{
    abstract class Party
    {
        public int People { get; set; }
        public string Location { get; set; }
        public string[] NameOfHosts { get; set; }
        public int Budget { get; set; }

        //this is a constructor
        public Party(int numberOfPeople)
        {
            People = numberOfPeople;
        }

        public Party()
        {

        }

        public Party(int budget, int numberOfPeople)
        {
            Budget = budget;
            People = numberOfPeople;

        }

        //this is an abstract method
        public abstract void Theme();

        public void BadDecisions()
        {
            Console.WriteLine("Don't do that, it's a bad desicion");
        }

        public void Games()
        {
            Console.WriteLine("We are playing bocce ball");
        }

        public int PartyBudget()
        {
            int budget = Budget;
            Console.WriteLine(budget);
            return budget;
        }

        public bool RSVP()
        {
            bool returned = true;
            return returned;
        }
    }
}
