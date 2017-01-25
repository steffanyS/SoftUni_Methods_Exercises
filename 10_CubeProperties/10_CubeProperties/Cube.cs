using System;

namespace _10_CubeProperties
{
    class Cube
    {
        //Write a program that can calculate the length of the face diagonals,
        //space diagonals, volume and surface area of a cube by a given side

        public static double CubeProperties(string parameter, double side)
        {
            switch (parameter)
            {
                case "face":
                    double face = Math.Sqrt(2*Math.Pow(side, 2));
                    return face;
                    break;
                case "space":
                    double space= Math.Sqrt(3 * Math.Pow(side, 2));
                    return space;
                    break;
                case "volume":
                    double volume = Math.Pow(side, 3);
                    return volume;
                    break;
                case "area":
                    double area = 6*Math.Pow(side, 2);
                    return area;
                    break;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            Console.WriteLine("{0:f2}",CubeProperties(property,side));
        }
    }
}
