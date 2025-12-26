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
        //DateFormatter df = new DateFormatter();
        //df.DisplayFormats();



        // Problem 4
        Console.Write("Enter first date (yyyy-MM-dd): ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date (yyyy-MM-dd): ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());
        DateComparison dc = new DateComparison();
        dc.CompareDates(date1, date2);

        Console.ReadKey();
    }
}
