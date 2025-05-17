/**
 * 10. Multiplication Table
 */

using System;

namespace _10.MultiplicationTable
{

    internal class Program
    {

        static void Main(string[] args)
        {

            int inputNumber = int.Parse(Console.ReadLine());

            for (int multiply = 1; multiply <= 10; multiply++)
            {
                Console.WriteLine($"{inputNumber} X {multiply} = {inputNumber * multiply}");
            }

        }

    }

}