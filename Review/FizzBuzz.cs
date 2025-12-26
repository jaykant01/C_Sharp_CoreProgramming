namespace Review;

public class FizzBuzz
{
    public void Review1()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine("Try Again");
            n = Convert.ToInt32(Console.ReadLine());
        }
        string res = (n % 3 == 0) ? "Fizz" : "Buzz";
        string res1 = (n % 3 == 0 && n % 5 == 0) ? "FizzBuzz" : res;
        // Console.WriteLine(res);
        Console.WriteLine(res1);
        Console.ReadKey();
    }
}
