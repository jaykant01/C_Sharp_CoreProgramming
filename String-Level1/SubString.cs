namespace String_Level1;

public class SubString
{
    public void CompareUsingCharAt()
    {
        string input = Console.ReadLine();
        int st = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        string sub = "";

        for (int i=st; i<end; i++)
        {
            sub += input[(i)];
        }

        Console.WriteLine(sub);

        // Substring using inbuilt method
        string insub = input.Substring(3,3);
        Console.WriteLine(insub);

        // Substring using inbuilt method from start index to end index
        string insub2 = input.Substring(2);
        Console.WriteLine(insub2);
        
    }

}
