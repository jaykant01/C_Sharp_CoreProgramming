namespace ProblemSet2;

class Program
{
    static void Main(string[] args)
    {
        // Problem 0 -> 0
        //Console.WriteLine("Enter the Year: ");
        //int year = int.Parse(Console.ReadLine());

        //Problem0 p0 = new Problem0();
        //p0.LeapYear(year);


        // Problem 0 -> 1
        //Console.WriteLine("Enter the marks of 3 subjects: ");
        //int phy = int.Parse(Console.ReadLine());
        //int chem = int.Parse(Console.ReadLine());
        //int math = int.Parse(Console.ReadLine());

        //Problem01 p01 = new Problem01();
        //p01.Grade(phy, chem, math);


        // Problem 1
        Console.WriteLine("Enter number to check Prime: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Problem1 p1 = new Problem1();
        p1.IsPrime(num);





        Console.ReadKey();
    }
}
