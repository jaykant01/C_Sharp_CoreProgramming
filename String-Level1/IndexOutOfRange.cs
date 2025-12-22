namespace String_Level1;

public class IndexOutOfRange
{
   public void Out()
    {
        string s = "Jaykant";
        try
        {
            for(int i=0; i<=s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception Caught: IndexOutOfRangeException");
            Console.WriteLine("Mesaage is : " + ex.Message);
        }
    }

}
