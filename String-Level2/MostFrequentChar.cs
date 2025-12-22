namespace String_Level2;

public class MostFrequentChar
{
    public void Freq()
    {
        string s = Console.ReadLine();
        int count = 0;
        int maxCount = 0;
        char maxCh = '\0';
        
        for (int i=0; i<s.Length; i++)
        {
            for(int j=0; j<s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                maxCh = s[i];
            }
        }
        Console.WriteLine("Most Frequent Character: '" + maxCh + "'");

    }
}
