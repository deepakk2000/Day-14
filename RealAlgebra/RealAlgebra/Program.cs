using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLib;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter\n1.Square,\n2.Reactangle,\n3.Circle,\n4.Triangle");
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1:
                    Console.WriteLine("Enter side value ");
                    int side = int.Parse(Console.ReadLine());
                    Console.WriteLine(Square.Area(side));
                    break;
                case 2:
                    Console.WriteLine("Enter Length value ");
                   
                    int Length = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Width value ");
                    int Width = int.Parse(Console.ReadLine());

                    Console.WriteLine(Reactangle.Area(Length,Width));
                    break;
                case 3:
                    Console.WriteLine("Enter Radious value ");
                    int Radious = int.Parse(Console.ReadLine());
                    Console.WriteLine(Circle.Area(Radious));
                    break;
                case 4:
                    Console.WriteLine("Enter Base value ");
                    int Base = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Height value ");
                    int Height = int.Parse(Console.ReadLine());
                    Console.WriteLine(Triangle.Area(Base,Height));
                    break;

            }
            
            
            
            
           
            
            
            
        }
    }
}
