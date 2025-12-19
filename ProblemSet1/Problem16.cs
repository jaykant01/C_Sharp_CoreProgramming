namespace ProblemSet1;

public class Problem16
{
    public void OddEven(int num)
    {
        for (int i = 2; i <= num; i++)
        {
           
            if (i % 2 == 0)
            {
                Console.WriteLine("It is Even number " + i);
            }
            else
            {
                Console.WriteLine("It is Odd number " + i);
            }
        }
    }
}
