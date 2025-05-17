/**
 * 11.MultiplicationTable2
 */

using System;

namespace _11.MultiplicationTable
{

    internal class Program
    {

        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{input} X {i} = {input * i}");
                }
            }
            else if (multiplier > 10)
            {
                Console.WriteLine($"{input} X {multiplier} = {input * multiplier}");
            }

        }

    }

}