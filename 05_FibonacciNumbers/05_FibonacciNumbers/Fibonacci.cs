using System;

namespace _05_FibonacciNumbers
{
    class Fibonacci
    {
        public static long Fib(long num)
        {
            long currentNum = 0;
            long startNum = 1;
            long sum = 1;
            if (num>0)
            {
                for (int i = 0; i < num; i++)
                {
                    sum = currentNum + startNum;
                    currentNum = startNum;
                    startNum = sum;
                }
                return sum;
            }
            else
            {
                return 1;
            }
        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(Fib(number));
        }
    }
}
