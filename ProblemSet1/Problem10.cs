namespace ProblemSet1;

public class Problem10
{
    public void Total(double val)
    {
        double sum = 0;
        while(val != 0)
        {
            sum += val;
            val = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}
