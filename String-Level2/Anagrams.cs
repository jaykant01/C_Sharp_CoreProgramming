namespace String_Level2;

public class Anagrams
{
    public void AnagramCheck()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        char[] arr1 = s1.ToCharArray();
        char[] arr2 = s2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        if(arr1.Length != arr2.Length)
        {
            Console.WriteLine("Not an Anagram");
        }
        else
        {
            for(int i=0; i<arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("Not an Anagram");
                    break;
                }
            }
            Console.WriteLine("It's an Anagram");
        }

    }
}
