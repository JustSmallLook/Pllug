using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class UserInput
    {
        public ulong UserNumberCheck()
        {
            ulong inputNumber = 0;
            while (true)
            {
                try
                {
                    inputNumber = ulong.Parse(Console.ReadLine());
                    return inputNumber;
                }
                catch (FormatException)
                {
                    Console.Write("Invalid input, please use only numbers: ");
                }
            }

        }
        public uint UserChoiceCheck()
        {
            uint choice = 0;
            while (true)
            {
                try
                {
                    Console.Write("\nPlease, make your choiсe: ");
                    choice = uint.Parse(Console.ReadLine());
                    if ((1 == choice) || (choice == 2) || (choice == 3))
                    {
                        return choice;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, use only numbers!");
                }
            }
        }
    }
}    
