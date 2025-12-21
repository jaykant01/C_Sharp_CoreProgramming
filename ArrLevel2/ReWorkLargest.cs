namespace ArrLevel2;
/*Rework the program 2, especially the Hint: if index equals maxDigit, we break from the loop.
Here we want to modify to increase the size of the array i,e maxDigit by 10 if the index is
equal to maxDigit. This is done to consider all digits to find the largest and second-largest
number
 */
public class ReWorkLargest
{
    public void ReWork()
    {
        int n = int.Parse(Console.ReadLine());
        int maxDigit = n;

        int[] arr = new int[maxDigit];

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        int i = 0;

       
        while (i < maxDigit)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());

            
            if (i == maxDigit - 1)
            {
                maxDigit += 10;

                int[] temp = new int[maxDigit];
                for (int j = 0; j < arr.Length; j++)
                {
                    temp[j] = arr[j];
                }

                arr = temp;
                break;
            }

            i++;
        }

        int count = i + 1; 

        
        for (int k = 0; k < count; k++)
        {
            if (arr[k] > largest)
            {
                secondLargest = largest;
                largest = arr[k];
            }
            else if (arr[k] < largest && arr[k] > secondLargest)
            {
                secondLargest = arr[k];
            }
        }

        Console.WriteLine("Largest is : " + largest);
        Console.WriteLine("Second Largest is : " + secondLargest);
    }
}
