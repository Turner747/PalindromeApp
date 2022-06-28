using System;

namespace PalindromeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare required variables
            int originalNumber, tempNumber, remainder, reverseNumber = 0;

            // get input
            Console.WriteLine("\n");
            Console.Write("Enter an integer number >> ");
            originalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            tempNumber = originalNumber; // store original number for later

            // output result
            Console.WriteLine("=====Find Reverse Number=====");
            Console.WriteLine("Original Number: {0}", tempNumber);
            while (originalNumber > 0)
            {
                remainder = originalNumber % 10; // get the last digit
                reverseNumber = reverseNumber * 10 + remainder; // add decimal place then add last digit
                originalNumber /= 10; // drop the last digit off the current number
                Console.WriteLine("{0}", reverseNumber); // out the iteration of the reversed number
            }       
            Console.WriteLine("Reverse Number: {0}", reverseNumber);
            Console.WriteLine("=============================\n");

            Console.WriteLine("=============================");
            if (tempNumber == reverseNumber) // if the numbers as the same
            { 
                Console.WriteLine("{0} is a Palindrone", tempNumber);
            }
            else // if they are not the same
            {
                Console.WriteLine("{0} is not a Palindrone", tempNumber);
            }
            Console.WriteLine("=============================\n");
            Console.ReadLine();
        }
    }
}
