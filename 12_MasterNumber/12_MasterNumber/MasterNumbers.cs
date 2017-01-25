using System;
using System.Collections.Generic;

namespace _12_MasterNumber
{
    class MasterNumbers
    {
        //A master number is an integer that holds the following properties:
        //Is symmetric(palindrome)
        //Its sum of digits is divisible by 7
        //Holds at least one even digit
        public static void PrintMasterNumbers(int range)
        {
            for (int i = 1; i < range; i++)
            {
                if (IsSymetric(FindDigits(i)) == true && DevisibleSum(FindDigits(i)) == true && HoldsEvenNumber(FindDigits(i)) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static List<int> FindDigits(int number)
        {
            var digits = new List<int>();
            int lastDigit = 0;
            while (number > 0)
            {
                lastDigit = number % 10;
                digits.Add(lastDigit);
                number /= 10;
            }
            return digits;
        }

        public static bool HoldsEvenNumber(List<int> numbers)
        {
            bool holdsEvenNumber = false;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    holdsEvenNumber = true;
                }
            }

            return holdsEvenNumber;
        }

        public static bool DevisibleSum(List<int> numbers)
        {
            bool isDevisible = false;
            decimal sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            if (sum % 7 == 0)
            {
                isDevisible = true;
            }

            return isDevisible;
        }

        public static bool IsSymetric(List<int> digits)
        {
            bool isSymetric = false;
            int count = 0;
            for (int i = 0; i < digits.Count / 2; i++)
            {
                if (digits[i] == digits[digits.Count - i - 1])
                {
                    count++;
                }
                if (count == digits.Count / 2)
                {
                    isSymetric = true;
                    count = 0;
                }
            }

            return isSymetric;
        }

        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            PrintMasterNumbers(range);
        }
    }
}
