namespace ArrLevel2;

public class FrequencyCount
{
    public void Freq()
    {
        int n = int.Parse(Console.ReadLine());
        int temp = n;
        int count = 0;

        // Count Digits
        while(temp > 0)
        {
            count++;
            temp /= 10;
        }

        int[] digits = new int[count];
        temp = n;

        for (int i=0; i<count; i++)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }

        // Frequency
        int[] frequency = new int[10];
        for (int i = 0; i < count; i++)
        {
            frequency[digits[i]]++;
        }

        Console.WriteLine("\nDigit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine($"Digit {i} appears {frequency[i]} time(s)");
            }
        }
    }
}
