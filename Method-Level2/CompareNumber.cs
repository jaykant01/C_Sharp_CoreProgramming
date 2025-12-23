namespace Method_Level2;
/* Write a program to take user input for 5 numbers and check whether a number is
positive or negative. Further for positive numbers check if the number is even or odd. Finally
compare the first and last elements of the array and display if they are equal, greater, or less
 */
public class CompareNumber
{
    public bool CheckPostiveAndNegative(int n)
    {
        if(n < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void EvenAndOdd(int n)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }

    public int CompareTwoNumbers(int n1,  int n2)
    {
        if(n1 == n2)
        {
            return 0;
        }else if (n1 > n2)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}
