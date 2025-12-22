namespace String_Level2;

public class ToggleCase
{
    public void Toggle()
    {
        string s = Console.ReadLine();
        string c = "";

        for(int i=0; i<s.Length; i++)
        {
            char ch = s[i];
            if(ch == ' ')
            {
                c += ch;
            }
            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
                c += ch;
            }
            else
            {
                ch = (char)(ch - 32);
                c += ch;
            }
        }

        Console.WriteLine(c);
    }
}
