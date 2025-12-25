namespace Method_Level3;
/* Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods
 */
public class NumberChecker
{
    public int CountDigit(int n)
    {
        int count = 0;
        
        while (n > 0)
        {
            int rem = n % 10;
            count = count + 1;
            n /= 10;
        }
        return count;
    }

    // Store Digit in Array
    public int[] StoreDigit(int n)
    {
        int[] digit = new int[CountDigit(n)];
        int i = 0;
        while(n > 0)
        {
            int rem = n % 10;
            digit[i] = rem;
            n /= 10;
            i++;
        }

        return digit;
    }

    
    public bool DuckNumber(int n)
    {
        int[] digits = StoreDigit(n);

        foreach (int d in digits)
        {
            if (d == 0)
                return true;
        }
        return false;
    }


    public bool ArmstrongNumber(int n)
    {
        int sum = 0;
        int temp = n;
        while(n > 0)
        {
            int rem = n % 10;
            sum = sum + (rem * rem * rem);
            n /= 10;
        }

        bool res = (temp == sum) ? true : false;
        return res;
    }


    public void SmallestNumber(int n)
    {
        int smallest = Int32.MaxValue;
        int sec = smallest;
        int[] digits = StoreDigit(n);

        for (int i=0; i<digits.Length; i++)
        {
            if (digits[i] < smallest)
            {
                sec = smallest;
                smallest = digits[i];
               
            }else if (digits[i] > smallest && digits[i] < sec)
            {
                sec = digits[i];
            }
        }

        Console.WriteLine("Smallest Number is " + smallest);
        Console.WriteLine("Second Smallest Number is " + sec);
    }

    public void LargestNumber(int n)
    {
        int largest = Int32.MinValue;
        int sec = largest;
        int[] digits = StoreDigit(n);

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] > largest)
            {
                sec = largest;
                largest = digits[i];

            }
            else if (digits[i] < largest && digits[i] > sec)
            {
                sec = digits[i];
            }
        }

        Console.WriteLine("Largest Number is " + largest);
        Console.WriteLine("Second Largest Number is " + sec);
    }
}
