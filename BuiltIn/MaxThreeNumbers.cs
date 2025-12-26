namespace BuiltIn;
/* Write a program that takes three integer inputs from the user and finds the maximum of the
three numbers.
 */
public class MaxThreeNumbers
{
    public void FindMaximum()
    {
        int[] numbers = TakeInput();
        int max = CalculateMaximum(numbers);

        Console.WriteLine("\nMaximum number is: " + max);
    }

    int[] TakeInput()
    {
        int[] nums = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        return nums;
    }

    int CalculateMaximum(int[] nums)
    {
        int max = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }

        return max;
    }
}
