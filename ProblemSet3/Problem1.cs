namespace ProblemSet3;

public class Problem1
{
    public void Armstrong(int number)
    {
        int sum = 0;
        int ogNumber = number;

        while (ogNumber > 0)
        {
            int rem = ogNumber % 10;
            sum += (rem * rem * rem);
            ogNumber /= 10;
        }

        Console.WriteLine("Sum is: " + sum);

        if (number == sum)
        {
            Console.WriteLine("Armstrong number");
        }else
        {
            Console.WriteLine("Not an Armstrong Number");
        }

    }
}
