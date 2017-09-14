using System;

namespace Class02Demo
{
    class Program
    {
        //double balance = 5280.00;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dr. Favorite's ATM World Express!");
            CashCash();
            
        }

        static int CashCash()
        {
            try
            {

                Console.WriteLine("What would you like to do. Enter a message: ");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please select from available options");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }finally
            {
                Console.WriteLine("Okay,");
            }
            return 0;
        }

        public void ViewBal(double balance)
        {
            Console.WriteLine($"Your balance is ${balance}");
        }

        static public void InputHandler()

        {
        double balance = 5280.00;
            int selection = CashCash();

            switch (selection)
            {
                case 1:
                    ViewBal(balance);
                    break;
                case 2:
                    Withdraw(balance);
                    break;
                case 3:
                    Deposit(balance);
                    break;
                default:
                    Console.WriteLine("Please choose from available options.");
                    InputHandler(balance);
                    break;
            }

            if (selection  == 1 )
            {
                ViewBal(balance);
            }

        }

        static public void Withdraw(double balance)
        {
            Console.WriteLine("How much would you like to withdraw today?");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            balance -= withdrawAmount;
            ViewBal(balance);
        }

        static public void Deposit(double balance)
        {
            Console.WriteLine("How much would you like to deposit today?");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            balance += depositAmount;
            ViewBal(balance);
        }
    }
}
