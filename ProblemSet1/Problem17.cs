namespace ProblemSet1;

public class Problem17
{
    public void Bonus(int salary, int year)
    {
        int bonus = 0;

        if(year >= 5)
        {
            bonus = salary * 5 / 100;
            Console.WriteLine("The Bonus amount is " + bonus);
        }
        else
        {
            Console.WriteLine("No Bonous is Applicable");
        }
    }
}
