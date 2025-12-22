namespace String_Level1;

public class AllCharacters
{
public void Characters()
    {
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();

        for (int i=0; i<input.Length; i++)
        {
            Console.WriteLine(input[i]);
            if (input[i] != arr[i])
            {
                Console.WriteLine("Not Equal");
                break;
            }
                
        }
        Console.WriteLine("input and Array are equal"); 
    }
}
