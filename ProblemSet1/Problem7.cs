namespace ProblemSet1;

public class Problem7
{
    public void Season(int month, int day)
    {
        if ((month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20))
        {
            if (day < 1 || day > 31)
            {
                Console.WriteLine("Invalid day");
                return;
            }
            Console.WriteLine("It's a Spring Season");
        }else
        {
            Console.WriteLine("Not a spring season");
        }
    }
}
