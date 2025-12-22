namespace String_Level2;

public class VowelsAndConsonants
{
    public void CountVowCon()
    {
        string s = Console.ReadLine();
        string vowels = "aeiou";
        int vowCount = 0;
        int consoCount = 0;

        for(int i=0; i< s.Length; i++)
        {
            if (vowels.Contains(s[i])){
                vowCount++;
            }
            else if (s[i] != ' ')
            {
                consoCount++;
            }
            else
            {
                continue;
            }
        }

        Console.WriteLine("Count of Vowels "+ vowCount);
        Console.WriteLine("Count of Consonants "+ consoCount);
    }
}
