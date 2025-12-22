namespace String_Level2;

public class ReplaceMethod
{
    public void Replace()
    {
        string s = Console.ReadLine();
        string oldWord = Console.ReadLine();
        string newWord = Console.ReadLine();
        string result = "";

        int i = 0;
        while (i < s.Length)
        {
            int j = 0;
            while(j < oldWord.Length && i+j < s.Length && s[i+j] == oldWord[j])
            {
                j++;
            }
            if(j == oldWord.Length)
            {
                result += newWord;
                i += oldWord.Length;
            }
            else
            {
                result += s[i];
                i++;
            }
        }
        Console.WriteLine(result);
    }
}
