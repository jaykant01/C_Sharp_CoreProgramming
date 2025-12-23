namespace Method_Level2;
/* Write a program that generates five 4 digit random values and then finds their
average value, and their minimum and maximum value. Use Math.Random(), Math.Min(),
and Math.Max().
 */
public class RandomNumGenerator
{
    public int[] Generate4DigitRandomArray(int size)
    {
        int[] numbers = new int[size];
        // Random Class 
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            // Syntax to Generate Random number
            numbers[i] = random.Next(1000, 10000);
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        return numbers;
    }


    public double[] FindAverageMinMax(int[] numbers)
    {
        int average = 0;
        int maxValue = 0;
        int minValue = int.MaxValue;
        double[] result = new double[3];

        for(int i=0; i<numbers.Length; i++)
        {
            average += numbers[i];
            maxValue = Math.Max(maxValue, numbers[i]);
            minValue = Math.Min(minValue, numbers[i]);

        }
        average = average / numbers.Length;
        result[0] = average;
        result[1] = minValue;
        result[2] = maxValue;

        Console.WriteLine("Average is " + average);
        Console.WriteLine("Min Value is " + minValue);
        Console.WriteLine("max Value is " + maxValue);

        return result;
    }



}
