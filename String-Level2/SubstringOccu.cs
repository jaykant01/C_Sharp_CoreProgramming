namespace String_Level2;

public class SubstringOccu
{
    public void SubString()
    {
        string s = Console.ReadLine();
        string sub = Console.ReadLine();
        int count = 0;

        for(int i=0; i<s.Length; i++)
        {
            int j = 0;

            while (j < sub.Length && s[i+j] == sub[j])
            {
                j++;
            }

            if(j == sub.Length)
            {
                count++;
            }
        }
        Console.WriteLine($"Substring '{sub}' occurs {count} times.");
    }
}
