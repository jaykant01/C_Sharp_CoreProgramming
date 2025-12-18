using System;

namespace Level2
{
    internal class Problem8
    {
        public void DisplayTripResult(string name,
        string fromCity,
        string viaCity,
        string toCity,

        double fromToVia,
        double viaToFinalCity,
        double timeTaken)
        {
            double totalDistance = fromToVia + viaToFinalCity;
            double averageSpeed = totalDistance / timeTaken;

            Console.WriteLine("\nThe results of the trip are:");
            Console.WriteLine($"Traveller Name: {name}");
            Console.WriteLine($"Route: {fromCity} -> {viaCity} -> {toCity}");
            Console.WriteLine($"Total Distance: {totalDistance} miles");
            Console.WriteLine($"Time Taken: {timeTaken} hours");
            Console.WriteLine($"Average Speed: {averageSpeed} miles/hour");
        }


    }
}

