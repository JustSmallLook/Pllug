using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frig_v2
{
    public class Logic
    {

        public void Compare(double height, double width, double depth,
            double heightHole, double widthHole, double diameter, double diameterHole)
        {
            //double diagonalbyHeight = FindDiagonal(height, width);
            //double diagonalbyWight = FindDiagonal(height, depth);
            //double diagonalbyDepth = FindDiagonal(width, depth);
            //double diagonalbyDiameter = FindDiagonal(height, diameter);

            if (((heightHole > height) & (widthHole > width)) | 
                    ((heightHole > height) & (widthHole > depth)) |
                    ((heightHole > width) & (widthHole > depth)) |
                    ((heightHole > depth) & (widthHole > width)))
            {
                Console.WriteLine("Yes, this object can pass through this hole!");
            }
            else if (((heightHole > height) & (widthHole > diameter)) || 
                    ((heightHole > diameter) & (widthHole > height)) ||
                    ((heightHole > diameter) & (widthHole > diameter)))
                //  ((diameterHole > diagonalbyHeight)) ||
                //  ((diameterHole > diagonalbyWight)) ||
                //  ((diameterHole > diagonalbyDepth)) ||
                //  ((diameterHole > diagonalbyDiameter)))
            {
                Console.WriteLine("Yes, this object can pass through this hole!");
            }
            else if (diameterHole > diameter)
            {
                Console.WriteLine("Yes, this object can pass through this hole!");
            }
            else
            {
                Console.WriteLine("No, it's impossible!");
            }
        }
        static double FindDiagonal(double a, double b)
        {
            double c = a * a + b * b;
            return Math.Sqrt(c);
        }

    }
}
