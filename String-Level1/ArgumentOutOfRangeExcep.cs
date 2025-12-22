namespace String_Level1;

public class ArgumentOutOfRangeExcep
{
    public void SubSt()
    {
        string input = "Jaykant";
        try
        {
            Console.WriteLine(input.Substring(3, 8));
        }catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Caught ArgumentOutOfRangeException: ");
            Console.WriteLine("Message is : " + ex.Message);
           
        }
    }
}
