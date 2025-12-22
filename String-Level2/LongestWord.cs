namespace String_Level2;

public class LongestWord
{
    public void Longest()
    {
        string s = Console.ReadLine();
        int count = 0;
        int max = 0;

        string currWord = "";
        string maxWord = "";

        for(int i=0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                count++;
                currWord += s[i];
            }
            else
            {
                max = Math.Max(max, count);
                maxWord = currWord;
                count = 0;
                currWord = "";
            }
        }

        Console.WriteLine(max);
        Console.WriteLine(maxWord);

    }
}
