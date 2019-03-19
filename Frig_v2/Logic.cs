using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frig_v2
{
    public class Logic
    {

        public void CompareSquares(double height, double width, double depth,
            double heightHole, double widthHole, double diameterHole)
        {
            double diagonalbyHeight = FindDiagonal(height, width);
            double diagonalbyWight = FindDiagonal(height, depth);
            double diagonalbyDepth = FindDiagonal(width, depth);

            if (((heightHole > height) && (widthHole > width)) || 
                    ((heightHole > height) && (widthHole > depth)) ||
                    ((heightHole > width) && (widthHole > depth)) ||
                    ((heightHole > depth) && (widthHole > width)) ||
                    ((diameterHole > diagonalbyHeight)) ||
                    ((diameterHole > diagonalbyWight)) ||
                    ((diameterHole > diagonalbyDepth)))
            {
                Console.WriteLine("Yes, this object can pass through this hole!");
            }
            else
            {
                Console.WriteLine("No, it's impossible!");
            }
        }
        public void CompareCylinder (double height, double diameter, double heightHole,
            double widthHole, double diameterHole)
        {
            double diagonalbyDiameter = FindDiagonal(height, diameter);

            if (((heightHole > height) && (widthHole > diameter)) ||
                ((widthHole > height) && (heightHole > diameter)) ||
                ((diameterHole > diameter)) ||
                ((diameterHole > diagonalbyDiameter)))
            {
                Console.WriteLine("Yes, this object can pass through this hole!");
            }
            else
            {
                Console.WriteLine("No, it's impossible!");
            }
        }
        public void CompareShpere (double heightHole, double widthHole,
            double diameterHole, double diameter)
        {
            if (((heightHole > diameter) && (widthHole > diameter)) ||
                (diameterHole > diameter))
            {
                Console.WriteLine("Yes, this object can pass through this hole!");
            }
            else
            {
                Console.WriteLine("No, it's impossible!");
            }
        }   
        static double FindDiagonal(double sideA, double sideB)
        {
            double diagonal = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return diagonal;
        }

    }
}
