namespace BuiltIn;

public class GuessingGame
{
    int low = 1;
    int high = 100;
    bool isCorrect = false;

    public void PlayGame()
    {
        while (!isCorrect)
        {
            int guess = GenerateGuess();
            Console.WriteLine($"Computer guesses: {guess}");

            char feedback = GetUserFeedback();
            UpdateRange(feedback, guess);
        }

        Console.WriteLine("Computer guessed your number correctly!");
    }

    int GenerateGuess()
    {
        return (low + high) / 2;
    }

    char GetUserFeedback()
    {
        Console.Write("Enter feedback (H/L/C): ");
        return Char.ToUpper(Console.ReadKey().KeyChar);
    }

    void UpdateRange(char feedback, int guess)
    {
        Console.WriteLine();

        if (feedback == 'H')
        {
            high = guess - 1;
        }
        else if (feedback == 'L')
        {
            low = guess + 1;
        }
        else if (feedback == 'C')
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter H, L, or C.");
        }
    }
}