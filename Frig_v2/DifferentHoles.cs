using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frig_v2
{
    public class DifferentHoles
    {
        public void Rectangular(out double heightHole, out double widthHole)
        {
            Console.WriteLine("You have selected rectangular hole!");
            UserInput input = new UserInput();

            heightHole = input.ObjectSize("height");
            widthHole = input.ObjectSize("width");
        }
        public void Round(out double diameterHole)
        {
            Console.WriteLine("You have selected round hole!");
            UserInput input = new UserInput();

            diameterHole = input.ObjectSize("diamater");

        }

    }
}
