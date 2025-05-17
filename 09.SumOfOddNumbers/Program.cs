/**
 * 09. Sum of Odd Numbers
 */

using System;

namespace _09.SumOfOddNumbers
{

    internal class Program
    {

        static void Main(string[] args)
        {

            int oddNumber = 1;
            int oddCounter = int.Parse(Console.ReadLine());
            int sumOddNumbers = 0;

            for (int i = 0; i < oddCounter; i++)
            {
                Console.WriteLine(oddNumber);
                sumOddNumbers += oddNumber;
                oddNumber += 2;
            }

            Console.WriteLine("Sum: {0}", sumOddNumbers);

            oddNumber = 1; 
            oddCounter = 0;
            sumOddNumbers = 0;

        }

    }

}