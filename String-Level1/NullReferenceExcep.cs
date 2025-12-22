namespace String_Level1;

public class NullReferenceExcep
{
    public void Null()
    {
        string input = null;
        try
        {
            int length = input.Length;
            Console.WriteLine("Length of string: " + length);

        }catch (NullReferenceException ex)
        {
            Console.WriteLine("Exception Caught: NullReferenceException");
            Console.WriteLine("String is Null: " + ex.Message);
        }
    }
}
