using System;
using System.Globalization;
namespace DateTimePractice;

class Program
{
    static void Main(string[] args)
    {

        // Problem 1
        //CurrTimeInDiffTimeZones tz = new CurrTimeInDiffTimeZones();
        //tz.DisplayTimeZones();



        // Problem 2
        //DateArithmetic dz = new DateArithmetic();
        //dz.CalculateDate();



        // Problem 3
        DateFormatter df = new DateFormatter();
        df.DisplayFormats();

        Console.ReadKey();
    }
}
