﻿/**
 * 02. Passed
 */

using System;

namespace _02.Passed;

internal class Program
{

    static void Main(string[] args)
    {

        double grade = double.Parse(Console.ReadLine());

        if (grade >= 3)
        {
            Console.WriteLine("Passed!");
        }
        else
        {
            Console.WriteLine("Failed!");
        }

    }

}