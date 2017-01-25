using System;

namespace _01_HelloName
{
    class Program
    {
        public static void Hello(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Hello(name);
        }
    }
}
