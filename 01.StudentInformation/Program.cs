/**
 * Basic syntax, conditional statements, loops and data types
 */

using System;

namespace _01.StudentInformation;

internal class Program
{

    static void Main(string[] args)
    {

        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        double average = double.Parse(Console.ReadLine());

        //"Name: {student name}, Age: {student age}, Grade: {student grade}".

        Console.WriteLine($"Name: {name}, Age: {age}, Grade: {average:F2}");

    }

}