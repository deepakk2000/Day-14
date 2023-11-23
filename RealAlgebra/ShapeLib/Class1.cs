using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public static class Reactangle
    {

        public static double Area(int Length, int Width)
        {
            return Length * Width;
        }

    }

    public static class Square
    {

        public static double Area(int Side)
        {
            return Side * Side;
        }
    }
    public static class Circle
    {

        public static double Area(int Radius)
        {
            return Math.PI * Radius * Radius;
        }
    }
    public static class Triangle
    {

        public static double Area(int Base, int Height)
        {
            return 0.5 * Base * Height;
        }
    }
    
}
