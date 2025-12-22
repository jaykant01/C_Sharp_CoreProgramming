namespace String_Level1;

public class UpperCaseConv
{
    public void Upper()
    {
        string s = Console.ReadLine();
        string c = "";
       
        for(int i= 0; i<s.Length; i++)
        {
            char ch = s[i];

            if (ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
            }
            c += ch;
        }
        Console.WriteLine("Manual : " + c);

        // Inbuilt method
        string newS = s.ToUpper();
        Console.WriteLine("Inbuilt : " + newS);

    }
}
