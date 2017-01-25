using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_PrimesInRange
{
    class Primes
    {
        //Write a method that calculates all prime numbers in given range and returns them as list of integers
        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var numbers=new List<int>();
            int count = 0;
            for (int i = startNum; i <=endNum; i++)
            {
                for (int j = 1; j <= Math.Sqrt(endNum); j++)
                {
                    if (i%j == 0)
                    { 
                        count++;
                    }
                }
                if ((count<2 && i!=1) || i==2 || i==3)
                {
                    numbers.Add(i);
                }
                count = 0;
            }
            return numbers;
        } 
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            var primeNumbers=new List<int>();
            primeNumbers = FindPrimesInRange(start, end);
            var stringNumbers=new List<string>();

            for (int i = 0; i < primeNumbers.Count; i++)
            {
                stringNumbers.Add(primeNumbers[i].ToString());
            }

            var str = string.Join(", ", stringNumbers);
            Console.WriteLine(str);
        }
    }
}
