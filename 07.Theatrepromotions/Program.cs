/**
 * Theatre Promotions
 */

using System;

namespace _07.TheatrePromotions;

internal class Program
{

    static void Main(string[] args)
    {

        string period = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        double ticketPrice = 0;

        //Weekday  >=0 <=18 ; >18 - <=64 ; >64 - <=122
        //Weekend
        //Holiday

        if (age >= 0 && age <= 18)
        {
            ticketPrice = period switch
            {
                "Weekday" => 12,
                "Weekend" => 15,
                "Holiday" => 5
            };
        }
        else if (age > 18 && age <= 64)
        {
            ticketPrice = period switch
            {
                "Weekday" => 18,
                "Weekend" => 20,
                "Holiday" => 12
            };
        }
        else if (age > 64 && age <= 122)
        {
            ticketPrice = period switch
            {
                "Weekday" => 12,
                "Weekend" => 15,
                "Holiday" => 10
            };
        }
        else
        {
            Console.WriteLine("Error!");
            Environment.Exit(0);
        }

        Console.WriteLine(ticketPrice);

    }

}