using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CenterPoint
{
    class CenterPoint
    {
        static void CloserPoint(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            if (Math.Abs(x1) + Math.Abs(y1) < Math.Abs(x2) + Math.Abs(y2))
            {
                Console.Write("({0}, {1})", x1, y1);
            }
            else if(Math.Abs(x1) + Math.Abs(y1) == Math.Abs(x2) + Math.Abs(y2))
            {
                Console.Write("({0}, {1})", x1, y1);
            }
            else
            {
                Console.Write("({0}, {1})", x2, y2);
            }
        }
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());

            CloserPoint(x1, y1, x2, y2);
        }
    }
}
