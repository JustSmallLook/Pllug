using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Display Fibonacci Magic");
            Console.Write("Choose what you want to do:" +
                "\n 1. Find Nth Fibonacci number" +
                "\n 2. Show Fibonacci sequence up to a certain number" +
                "\n 3. Show Fibonacci series up to N number of terms");

            UserInput option = new UserInput();
            uint userSelection = option.UserChoiceCheck();

            Console.Write("Enter a number: ");
            ulong number = option.UserNumberCheck();

            if (userSelection == 1)
            {
                Fibonacci.FibonacciNumber(number); 
            }
            else if (userSelection == 2)
            {
                Fibonacci.FibonacciUpToNumber(number);
            }
            else if (userSelection == 3)
            {
                Fibonacci.FibonacciNumberOfTerms(number);
            }

            Console.ReadKey();


        }
    }
}
