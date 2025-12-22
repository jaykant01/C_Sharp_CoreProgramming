namespace String_Level1;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 String Compare
        //Console.WriteLine("Enter Two Strings: ");
        //string s = Console.ReadLine();
        //string k = Console.ReadLine();

        // Comparing by Inbuilt method
        //CompareTwoStrings cp = new CompareTwoStrings();
        //cp.Compare(s,k);

        // Comparing by CharAt method
        //CompareTwoStrings sc = new CompareTwoStrings();
        //bool res1 = sc.CompareUsingCharAt(s,k);
        //Console.WriteLine("\nManual Comparison Result: " + res1);




        // Problem 2 Sub String
        Console.WriteLine("Enter string input");
        
        SubString sa = new SubString();
        sa.CompareUsingCharAt();

        Console.ReadKey();
    }
}
