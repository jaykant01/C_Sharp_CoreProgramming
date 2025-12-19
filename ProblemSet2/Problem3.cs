namespace ProblemSet2;

public class Problem3
{
    public void Fizz(int inpu)
    {
        if (inpu > 0)
        {
            int i = 0;
            while (inpu >= i)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
