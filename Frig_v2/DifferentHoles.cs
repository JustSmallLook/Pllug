using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frig_v2
{
    public class DifferentHoles
    {
        public void HoleChoice (out double heightHole, out double widthHole, out double diameterHole)
        {
            heightHole = 0;
            widthHole = 0;
            diameterHole = 0;

            Console.WriteLine("Select the shape of the hole, " +
                "through which you want to push the object");
            Console.WriteLine("\n 1. Rectangular" + "\n 2. Round");

            UserChoice numberObject = new UserChoice();
            int optionHole = numberObject.UserChoiceHole();
            DifferentHoles holes = new DifferentHoles();

            if (optionHole == 1)
            {
                holes.Rectangular(out heightHole, out widthHole);
            }
            else if (optionHole == 2)
            {
                holes.Round(out diameterHole);
            }
        }
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
