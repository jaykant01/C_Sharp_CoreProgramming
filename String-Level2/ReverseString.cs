namespace String_Level2;

public class ReverseString
{
    public void Reverse()
    {
        string s = Console.ReadLine();
        string r = "";
        int st = 0;
        int end = s.Length - 1;

        for(int i=s.Length-1; i>=0; i--)
        {
            r += s[i];
        }
        Console.WriteLine(r);
    }
}
