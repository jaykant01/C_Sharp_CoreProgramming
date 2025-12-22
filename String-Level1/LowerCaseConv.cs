namespace String_Level1;

public class LowerCaseConv
{
    public void Lower()
    {
        string s = Console.ReadLine();
        string c = "";

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }
            c += ch;
        }
        Console.WriteLine("Manual : " + c);

        // Inbuilt method
        string newS = s.ToLower();
        Console.WriteLine("Inbuilt : " + newS);

    }
}
