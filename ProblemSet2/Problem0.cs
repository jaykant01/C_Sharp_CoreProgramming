namespace ProblemSet2;

public class Problem0
{
    public void LeapYear(int year)
    {
        if ((year % 4 == 0) || (year % 400 == 0 && year % 100 != 0))
        {
            Console.WriteLine("It is a Leap Year " + year);
        }else
        {
            Console.WriteLine("The Year is not a Leap Year " + year);
        }
    }
}
