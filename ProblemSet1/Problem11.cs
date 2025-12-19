namespace ProblemSet1;

public class Problem11
{
    public void TotalNew(double value)
    {
        double sum = 0;
        while (true)
        {
            if (value <= 0)
            {
                break;
            }
            sum += value;
            value = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}
