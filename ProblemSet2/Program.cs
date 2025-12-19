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
        //Console.WriteLine("Enter number to check Prime: ");
        //int num = Convert.ToInt32(Console.ReadLine());

        //Problem1 p1 = new Problem1();
        //p1.IsPrime(num);



        // Problem 2
        //Console.WriteLine("Enter the number input: ");
        //int inp = int.Parse(Console.ReadLine());

        //Problem2 p2 = new Problem2();
        //p2.FizzBuzz(inp);



        // Problem 3
        //Console.WriteLine("Enter the number input: ");
        //int inpu = int.Parse(Console.ReadLine());

        //Problem3 p3 = new Problem3();
        //p3.Fizz(inpu);



        // Problem 4
        //Console.WriteLine("Enter the Weight & Height");
        //double weight = Convert.ToDouble(Console.ReadLine());
        //double height = Convert.ToDouble(Console.ReadLine());

        //Problem4 p4 = new Problem4();
        //p4.BMI(weight, height);




        // Problem 5
        Console.WriteLine("Enter the Age & Height");
        int age1 = Convert.ToInt32(Console.ReadLine());
        int age2 = Convert.ToInt32(Console.ReadLine());
        int age3 = Convert.ToInt32(Console.ReadLine());
        double ht1 = Convert.ToDouble(Console.ReadLine());
        double ht2 = Convert.ToDouble(Console.ReadLine());
        double ht3 = Convert.ToDouble(Console.ReadLine());

        Problem5 p5 = new Problem5();
        p5.AgeHeight(age1, age2,age3, ht1, ht2, ht3);

        Console.ReadKey();
    }
}
