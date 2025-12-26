namespace DateTimePractice;
/* Create a program that:
● Takes a date input and adds 7 days, 1 month, and 2 years to it.
● Then subtracts 3 weeks from the result.
 */
public class DateArithmetic
{
    public void CalculateDate()
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        DateTime resultDate = inputDate;

        resultDate = inputDate.AddDays(7);
        resultDate = inputDate.AddMonths(1);
        resultDate = inputDate.AddYears(2);
        resultDate = inputDate.AddDays(-21);

        Console.WriteLine("New Date is " + resultDate);

    }
}
