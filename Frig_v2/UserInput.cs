using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frig_v2
{
    public class UserInput
    {
        public double ObjectSize(string proportions)
        {
            double size = 0;
            while (true)
            {
                Console.Write("Please, enter {0}:", proportions);
                try
                {
                    size = double.Parse(Console.ReadLine());
                    return size;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please use only numbers: ");
                }
            }

        }
        
    }

}         
            
    
 

