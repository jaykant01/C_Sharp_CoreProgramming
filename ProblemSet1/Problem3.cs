namespace ProblemSet1;

public class Problem3
{
    public void Largest(int x, int y, int z)
    {
        if (x > y && x > z)
        {
            Console.WriteLine("Is the first number the largest? Yes");
        }else if (y > x && y > z)
        {
            Console.WriteLine("Is the second number the largest? Yes");
        }else
        {
            Console.WriteLine("Is the third number the largest? Yes");
        }
    }
}
