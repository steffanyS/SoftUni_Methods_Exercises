using System;
using System.Linq;

namespace _04_ReversedNumbers
{
    class ReversedNumbers
    {
        public static decimal ReverseNumbers(string number)
        {
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            string reversedNumberString = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                reversedNumberString +=array[i];
            }
            
            decimal reversedNumber = decimal.Parse(reversedNumberString);
            return reversedNumber;
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            decimal reversedNumber = ReverseNumbers(number);
            Console.WriteLine(reversedNumber);
        }
    }
}
