using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GeometryCalculator
{
    class Geometry
    {
        public static double TriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }

        public static double SquareArea(double side)
        {
            double area = side * side;
            return area;
        }

        public static double ReactangleTriangleArea(double width, double height)
        {
            double area = width*height;
            return area;
        }

        public static double CircleArea(double radius)
        {
            double area = Math.PI*Math.Pow(radius,2);
            return area;
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}",TriangleArea(triangleSide, height));
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", SquareArea(squareSide));
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", ReactangleTriangleArea(rectangleWidth,rectangleHeight));
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", CircleArea(radius));
                    break;
            }
        }
    }
}
