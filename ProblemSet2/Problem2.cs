namespace ProblemSet2;

public class Problem2
{
    public void FizzBuzz(int inp)
    {
        if(inp > 0)
        {
            for(int i = 0; i<= inp; i++)
            {
                if(i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }else if (i%3== 0 && i%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
