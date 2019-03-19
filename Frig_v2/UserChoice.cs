using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frig_v2
{
    public class UserChoice
    {
        public int UserChoiceNumber()
        {
            int choice = 0;
            while (true)
            {
                try
                {
                    Console.Write("\nPlease, make your choiсe: ");
                    choice = int.Parse(Console.ReadLine());
                    if ((1<=choice) && (choice <= 3))
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
        public int UserChoiceHole()
        {
            int hole = 0;
            while (true)
            {
                try
                {
                    Console.Write("\nPlease, make your choiсe: ");
                    hole = int.Parse(Console.ReadLine());
                    if ((1 == hole) || (hole == 2))
                    {
                        return hole;
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
