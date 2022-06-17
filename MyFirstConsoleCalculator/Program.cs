using System;

namespace MyFirstConsoleCalculator
{
    public class MyCalculator
    {
        public static void Main()
        {

            LogicCalculator.Begin();
            Random accountNumber = new Random();
            accountNumber.Next();
            Console.WriteLine(accountNumber.Next(111111, 999999).ToString());
        }
    }
}