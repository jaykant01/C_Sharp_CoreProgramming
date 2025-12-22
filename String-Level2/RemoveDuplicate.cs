namespace String_Level2;

public class RemoveDuplicate
{
    public void Duplicate()
    {
        string s = Console.ReadLine();
        char[] arr = s.ToCharArray();
        string d = "";

        for(int i=0; i<arr.Length; i++)
        {
            if (d.Contains(arr[i]))
            {
                continue;
            }
            else
            {
                if (arr[i] == ' ')
                {
                    continue;
                }
                else
                {
                    d += arr[i];
                }
                    
            }
        }

        Console.WriteLine(d);
    }
}
