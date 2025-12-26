namespace BuiltIn;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //Console.WriteLine("Think of a number between 1 and 100.");
        //Console.WriteLine("Give feedback:");
        //Console.WriteLine("H = Too High, L = Too Low, C = Correct\n");

        //GuessingGame game = new GuessingGame();
        //game.PlayGame();



        // Problem 2
        MaxThreeNumbers mx = new MaxThreeNumbers();
        mx.FindMaximum();

        Console.ReadKey();
    }
}
