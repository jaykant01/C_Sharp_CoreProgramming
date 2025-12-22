namespace String_Level1;

public class CompareTwoStrings
{/*Compare Two Strings Using charAt()
  */
    public void Compare(string s, string k)
    {
        // In built method compare
        bool res2 = s.Equals(k);
        bool res3 = string.Equals(s, k);

        Console.WriteLine("Built-in Equals Result1: " + res2);
        Console.WriteLine("Built-in Equals Result2: " + res3);
         
    }

    // compare using charAt
    public bool CompareUsingCharAt(string s, string k)
    {
        if (s.Length != k.Length)
        {
            return false;
        }

        for(int i=0; i<s.Length; i++)
        {
            if (s[i] != k[i])
            {
                return false;
            }
             
        }
        return true;
    }
}
