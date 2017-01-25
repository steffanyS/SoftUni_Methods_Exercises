using System;
using System.Numerics;

namespace _14_FactorialZeroes
{
    class Factorial
    {
        public static BigInteger FindFactoriel(int number)
        {
            BigInteger factoriel = 1;
            for (int i = 1; i <= number; i++)
            {
                factoriel *= i;
            }

            return factoriel;
        }

        public static int CountTrailingZeroes(BigInteger fact)
        {
            int count = 0;
            BigInteger lastdigit;

            while (fact > 0)
            {
                lastdigit = fact % 10;
                if (lastdigit == 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
                fact /= 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CountTrailingZeroes(FindFactoriel(number)));
        }
    }
}
