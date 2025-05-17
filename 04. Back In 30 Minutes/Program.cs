/**
 * 04. Back In 30 Minutes
 */

using System;

namespace _01.BackIn30Minutes;

internal class Program
{

    static void Main(string[] args)
    {

        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 30;

        if (minutes >= 60)
        {
            minutes = minutes - 60;
            hours++;

            if (hours >= 24)
            {
                hours -= 24;
            }
        }

        if (minutes > 9)
        {
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
        else
        {
            Console.WriteLine($"{hours}:{minutes}");
        }

    }

}