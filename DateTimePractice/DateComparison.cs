namespace DateTimePractice;
/* Write a program that:
● Takes two date inputs and compares them to check if the first date is
before, after, or the same as the second date.
 */
public class DateComparison
{
    public void CompareDates(DateTime date1, DateTime date2)
    {
        int result = DateTime.Compare(date1, date2);

        if (result < 0)
        {
            Console.WriteLine("First date is BEFORE the second date.");
        }
        else if (result > 0)
        {
            Console.WriteLine("First date is AFTER the second date.");
        }
        else
        {
            Console.WriteLine("Both dates are the SAME.");
        }
    }
}
