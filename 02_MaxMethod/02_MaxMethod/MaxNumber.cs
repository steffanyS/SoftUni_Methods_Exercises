using System;

namespace _02_MaxMethod
{
    class MaxNumber
    {
        //Create a method GetMax(int a, int b), that returns maximal of two numbers. 
        //Write a program that reads three numbers from the console and prints the biggest of them.
        //Use the GetMax(…) method you just created.

        public static int GetMax(int firstNumber, int secondNumber)
        {
            int max = firstNumber;
            if (secondNumber > firstNumber)
            {
                max = secondNumber;
            }

            return max;
        }
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int maxNumber = GetMax(firstNumber, secondNumber);
            if (thirdNumber>maxNumber)
            {
                maxNumber = thirdNumber;
            }

            Console.WriteLine(maxNumber);
        }
    }
}
