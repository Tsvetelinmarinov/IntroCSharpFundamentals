/**
 * 06. Foreign Languages
 */

using System;

namespace _06.ForeginLanguages;

internal class Program
{

    static void Main(string[] args)
    {

        string countryName = Console.ReadLine();

        //English is spoken in England and the USA. 
        //Spanish is spoken in Spain, Argentina, and Mexico. 
        //For the others, we should print "unknown".

        string language = string.Empty;

        Console.WriteLine
        (
            language = countryName switch
            {
                "England" or "USA" => "English",
                "Spain" or "Argentina" or "Mexico" => "Spanish",
                _ => "unknown"
            }
        );

    }

}