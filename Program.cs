using System;

namespace PalindromeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int originalNumber, tempNumber, remainder, reverseNumber = 0;

            Console.WriteLine("\n");
            Console.Write("Enter an integer number >> ");
            originalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            tempNumber = originalNumber;

            Console.WriteLine("=====Find Reverse Number=====");
            while (originalNumber > 0)
            {
                remainder = originalNumber % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                originalNumber /= 10;
                Console.WriteLine("{0}", reverseNumber);
            }
            Console.WriteLine("=============================");
            Console.WriteLine("Original Number: {0}", tempNumber);
            Console.WriteLine("Reverse Number: {0}", reverseNumber);
            Console.WriteLine("=============================\n");

            Console.WriteLine("=============================");
            if (tempNumber == reverseNumber)
            {
                Console.WriteLine("{0} is a Palindrone", tempNumber);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrone", tempNumber);
            }
            Console.WriteLine("=============================\n");
            Console.ReadLine();
        }
    }
}
