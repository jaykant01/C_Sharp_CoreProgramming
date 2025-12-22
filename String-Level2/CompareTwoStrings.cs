namespace String_Level2;

public class CompareTwoStrings
{
    public void Compare()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        for (int i=0; i< (s1.Length + s2.Length); i++)
        {
            char ch1 = s1[i];
            char ch2 = s2[i];
            int asci1 = (int)ch1;
            int asci2 = (int)ch2;


            if(asci1 < asci2)
            {
                Console.WriteLine($"{s1} comes before {s2} in lexicographical order");
                break;
            }else if(asci2 < asci1)
            {
                Console.WriteLine($"{s2} comes before {s1} in lexicographical order");
                break;
            }
            else
            {
                continue;
            }
            
        }

    }
}
