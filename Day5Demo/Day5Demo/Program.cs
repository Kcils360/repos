using System;

namespace Day5Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SixFlags denver = new SixFlags();
            Console.WriteLine(  denver.CollectFees());
            Console.Read();
        }
    }
}
