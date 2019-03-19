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
            DifferentObjects selectedObject = new DifferentObjects();
            DifferentHoles selectedHole = new DifferentHoles();
            Logic result = new Logic();

            if (option == 1)
            {
                selectedObject.Parallelepiped(out height, out width, out depth);
                selectedHole.HoleChoice(out heightHole, out widthHole, out diameterHole);
                result.CompareSquares(height, width, depth, heightHole, widthHole, diameterHole);
            }
            else if (option == 2)
            {
                selectedObject.Ñylinder(out height, out diameter);
                selectedHole.HoleChoice(out heightHole, out widthHole, out diameterHole);
                result.CompareCylinder(height, diameter, heightHole, widthHole, diameterHole);
            }
            else if (option == 3)
            {
                selectedObject.Sphere(out diameter);
                selectedHole.HoleChoice(out heightHole, out widthHole, out diameterHole);
                result.CompareShpere(heightHole, widthHole, diameterHole, diameter);
            }

            Console.ReadKey();

        }
    }
}
