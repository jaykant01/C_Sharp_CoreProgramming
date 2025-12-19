namespace ProblemSet1;

    public class Problem1
    {
        public void CheckDivisible(int number)
        {
            if (number % 5 == 0)
            {
                Console.WriteLine("Is the number {0} divisible by 5? Yes", number);
            }
            else
            {
                Console.WriteLine("Is the number {0} divisible by 5? No", number);
            }
        }
    }

