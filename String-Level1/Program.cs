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
        //Console.WriteLine("Enter string input");

        //SubString sa = new SubString();
        //sa.CompareUsingCharAt();



        // Problem 3
        //Console.WriteLine("Enter String Input: ");
        //AllCharacters al = new AllCharacters();
        //al.Characters();



        // Problem 4 Null Reference Exception
        //Console.WriteLine("Null Reference: ");
        //NullReferenceExcep ep = new NullReferenceExcep();
        //ep.Null();



        // Problem 5 Index Out Of Range Exception
        //Console.WriteLine("Index Out of Range");
        //IndexOutOfBoundExcep ix = new IndexOutOfBoundExcep();
        //ix.Range();



        // Problem 6 Argument Out of Range Exception
        //Console.WriteLine("Argument Out of range");
        //ArgumentOutOfRangeExcep ep = new ArgumentOutOfRangeExcep();
        //ep.SubSt();


        // Problem 7 Format Exception
        //FormatExcep fp = new FormatExcep();
        //fp.Format();


        // Problem 8 IndexOutOfRange Exception
        //IndexOutOfRange of = new IndexOutOfRange();
        //of.Out();



        // Problem 9 Upper Case
        //Console.WriteLine("Enter the string in small: ");
        //UpperCaseConv up = new UpperCaseConv();
        //up.Upper();




        // Problem 10 Lower Case
        Console.WriteLine("Enter the string in Upper: ");
        LowerCaseConv lw = new LowerCaseConv();
        lw.Lower();


        Console.ReadKey();
    }
}
