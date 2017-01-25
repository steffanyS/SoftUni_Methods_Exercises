using System;

namespace _06_PrimeChecker
{
    class Prime
    {
        //Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
        public static bool IsPrime(long number)
        {
            bool prime = true;
            int count = 0;
            for (int i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number%i == 0)
                {
                    count++;
                }
            }

            if (count>1 || number==0 || number==1)
            {
                prime = false;
            }
            return prime;
        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }
    }
}
