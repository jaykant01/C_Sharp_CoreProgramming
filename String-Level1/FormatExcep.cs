namespace String_Level1;

public class FormatExcep
{
    public void Format()
    {
        try
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Your entered: " + input);

        }catch (FormatException ex)
        {
            Console.WriteLine("Format exception is caught: ");
            Console.WriteLine("the message is :" + ex.Message);
        }
    }
}
