namespace ArLevel1;

public class Problem4
{
    public void Stop()
    {
        double[] arr = new double[10];
        double total = 0.0;
        int i = 0;
        while (true)
        {
            double input = Convert.ToDouble(Console.ReadLine());
            if (input <= 0)
            {
                break;
            }
            if (i == 10)
            {
                break;
            }

            arr[i] = input;
            i++;
        }

        for (int j = 0; j < i; j++)
        {
            Console.WriteLine(arr[j]);
            total += arr[j];
        }
        Console.WriteLine("Total is" + total);

    }
}
