using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Frig_v2
{
    public class DifferentObjects 
    {
        public void Parallelepiped(out double height, out double width, out double depth)
        {
            Console.WriteLine("You have selected parallelepiped!");
            UserInput input = new UserInput();

            height = input.ObjectSize("height");
            width = input.ObjectSize("width");
            depth = input.ObjectSize("depth");
        }
        public void Сylinder(out double height, out double diameter)
        {
            Console.WriteLine("You have selected сylinder!");
            UserInput input = new UserInput();

            height = input.ObjectSize("height");
            diameter = input.ObjectSize("diamater");
        }
        public void Sphere(out double diameter)
        {
            Console.WriteLine("You have selected sphere!");
            UserInput input = new UserInput();

            diameter = input.ObjectSize("diamater");
        }

    }

}
