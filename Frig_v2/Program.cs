using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frig_v2
{
    class Program
    {
        public static void Main()
        {
            double height = 0;
            double width = 0;
            double depth = 0;
            double diameter = 0;
            double heightHole = 0;
            double widthHole = 0;
            double diameterHole = 0;

            Console.WriteLine("Snap objects through holes v2.0");
            Console.WriteLine(new string ('-', 31));
            Console.WriteLine("Choose object that you want to push through:");
            Console.WriteLine("\n 1. Parallelepiped"+ "\n 2. Ñylinder" +"\n 3. Ball");

            UserChoice numberObject = new UserChoice();
            int option = numberObject.UserChoiceNumber();
            DifferentObjects selected = new DifferentObjects();
            
            if (option == 1)
            {
                selected.Parallelepiped(out height, out width, out depth);
            }
            else if (option == 2)
            {
                selected.Ñylinder(out height, out diameter);  
            }
            else if (option == 3)
            {
                selected.Sphere(out diameter);
            }

            Console.WriteLine("Select the shape of the hole, " +
                "through which you want to push the object");
            Console.WriteLine("\n 1. Rectangular" + "\n 2. Round");

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

            Logic result = new Logic(); 
            result.Compare(height, width, depth, heightHole, widthHole, diameter, diameterHole);
            Console.ReadKey();

        }
    }
}
