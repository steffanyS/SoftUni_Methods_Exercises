using System;
using System.Numerics;

namespace _13_Factorial
{
    class Factorial
    {
        static BigInteger FindFactoriel(int number)
        {
            BigInteger factoriel = 1;
            for (int i = 1; i <= number; i++)
            {
                factoriel *= i;
            }

            return factoriel;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factoriel = FindFactoriel(number);
            Console.WriteLine(factoriel);
        }
    }
}
