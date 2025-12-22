namespace String_Level1;

public class SplitLength
{
    public void SplitText()
    {
        string text = Console.ReadLine();
        int count = 1;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
                count++;
        }

        // Step 2: Create 2D array [words, 2]
        string[,] result = new string[count, 2];

        int index = 0;
        string merge = "";


        for (int i=0; i<text.Length; i++)
        {
            if (text[i] != ' ')
            {
                merge += text[i];
            }
            else
            {
                result[index, 0] = merge;
                result[index, 1] = WordLength(merge).ToString();
                index++;
                merge = "";
            } 
        }

        result[index, 0] = merge;
        result[index, 1] = WordLength(merge).ToString();

        Console.WriteLine("\nWord   Length");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            Console.WriteLine(result[i, 0] + " --> " + result[i, 1]);
        }

    }


    public int WordLength(string text)
    {
        int count = 0;
        foreach (char ch in text)
        {
            count++;
        }
        return count;
    }
}
