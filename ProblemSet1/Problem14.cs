namespace ProblemSet1;

public class Problem14
{
    public void Fact(int num)
    {
        int f = 1;
        while (num > 0)
        {
            f *= num;
            //f++;
            num--;
        }
        Console.WriteLine("Factorail is "+ f);
    } 
}
