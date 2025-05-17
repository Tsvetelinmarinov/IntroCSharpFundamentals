/**
 * 12. Even Number
 */

using System;

namespace _12.EvenNumber;

internal class Program
{

    static void Main(string[] args)
    {

        //Create a program that reads a sequence of numbers.
        //If the number is even, print its absolute value in the following format: "The number is: {number}"
        // and terminate the program.
        // If the number is odd, print "Please write an even number." and continue reading numbers. 

        int input;

        while (true)
        {
            input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("The number is: {0}", Math.Abs(input));
                break;
            }
            else
            {
                Console.WriteLine("Please write an even number.");
                continue;
            }

        }

    }

}