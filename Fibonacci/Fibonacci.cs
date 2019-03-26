using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        public static void FibonacciNumber(ulong number)
        {
            {
                Console.Write(number);

                ulong[] f = new ulong[number + 2];
                ulong i;

                f[0] = 0;
                f[1] = 1;

                for (i = 2; i <= number; i++)
                {
                    f[i] = f[i - 1] + f[i - 2];
                }
                Console.Write(" Fibonacci number is: " + f[number]);
            }
        }
        public static void FibonacciUpToNumber(ulong number)
        {
            if (number > 1)
            {
                Console.WriteLine("The Fibonacci numbers less than " + number + " are: ");
                Console.Write("1, 1, ");

                ulong f2 = 1;
                ulong f1 = 1;

                for (ulong i = 1; i + f2 < number;)
                {
                    f1 = i + f2;
                    i = f2;
                    f2 = f1;
                    Console.Write(f1 + ", ");
                }
            }
            else
            {
                Console.WriteLine("There are no numbers less than " + number + " in the series");
            }
            
        }
        public static void FibonacciNumberOfTerms(ulong number)
        {
            if (number > 1)
            {
                Console.WriteLine("Fibonacci series up to " + number + " of terms is: ");

                ulong f1 = 0, f2 = 1, i;

                for (i = 1; i <= number; i++)
                {
                    Console.Write(f2 + ", ");
                    ulong next = f1 + f2;
                    f1 = f2;
                    f2 = next;
                } 
            }
            else
            {
                Console.WriteLine("The number of terms can not be " + number);
            }   
            
        }
    }
}
