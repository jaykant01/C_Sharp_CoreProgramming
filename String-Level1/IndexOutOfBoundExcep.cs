namespace String_Level1;

public class IndexOutOfBoundExcep
{
    public void Range()
    {
        string input = "Jaykant";
        char[] arr = input.ToCharArray();
        try
        {
            for(int i=0; i<input.Length; i++)
            {
                if (arr[i + 1] == input[i])
                {
                    Console.WriteLine("Equal");
                }
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception Caught: IndexOutOfRangeException");
            Console.WriteLine("String is Null: " + ex.Message);
        }
    }
}
