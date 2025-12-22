namespace String_Level2;

public class RemoveCharacter
{
    public void Remove()
    {
        string s = Console.ReadLine();
        char ch = Console.ReadLine()[0];
        string c = "";

        for(int i=0; i<s.Length; i++)
        {
            if (s[i] == ch)
            {
                continue;
            }
            else
            {
                c += s[i];
            }
        }
        Console.WriteLine(c);
    }
}
