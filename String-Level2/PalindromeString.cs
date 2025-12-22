namespace String_Level2;

public class PalindromeString
{
    public void Palindrome()
    {
        string s = Console.ReadLine();
        int n = s.Length;
        bool flag = true;

        for(int i=0; i<n; i++)
        {
            if (s[i] != s[n - 1 - i])
            {
                flag = false;
                
                break;
            }
        }

        if (flag)
        {
            Console.WriteLine("It is a Palindrome");
        }
        else
        {
            Console.WriteLine("Not a Palindrome");
        }
    }
}
