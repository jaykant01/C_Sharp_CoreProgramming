namespace DateTimePractice;
/* Write a program that Date Formatting
 */
public class DateFormatter
{
    public void DisplayFormats()
    {
        DateTime today = DateTime.Now;

        Console.WriteLine("Date Formats:\n");

        // dd/MM/yyyy
        Console.WriteLine("dd/MM/yyyy  : " + today.ToString("dd/MM/yyyy"));

        // yyyy-MM-dd
        Console.WriteLine("yyyy-MM-dd  : " + today.ToString("yyyy-MM-dd"));

        // EEE, MMM dd, yyyy
        Console.WriteLine("EEE, MMM dd, yyyy : " + today.ToString("ddd, MMM dd, yyyy"));
    }
}
