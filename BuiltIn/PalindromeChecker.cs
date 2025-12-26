namespace BuiltIn;
/* Write a program that checks if a given string is a palindrome (a word, phrase, or sequence
that reads the same backward as forward).
 */
public class PalindromeChecker
{
    public void Run()
    {
        string text = TakeInput();
        bool isPalindrome = CheckPalindrome(text);
        DisplayResult(isPalindrome);
    }

    string TakeInput()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }

    bool CheckPalindrome(string text)
    {
        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    void DisplayResult(bool isPalindrome)
    {
        if (isPalindrome)
            Console.WriteLine("The string is a Palindrome.");
        else
            Console.WriteLine("The string is NOT a Palindrome.");
    }
}
