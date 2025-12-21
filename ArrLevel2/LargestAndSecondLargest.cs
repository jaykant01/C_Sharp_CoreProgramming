namespace ArrLevel2;

/* Create a program to store the digits of the number in an array and find the largest and
second largest element of the array.
 */
public class LargestAndSecondLargest
{
    public void Largest()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        // Scan Array
        for (int i=0; i<n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        for (int i=0; i<n; i++)
        {
            if (largest < arr[i])
            {
                secondLargest = largest;
                largest = arr[i];  
            }else if (arr[i] < largest && arr[i] > secondLargest)
            {
                secondLargest = arr[i];
            }
        }

        Console.WriteLine("Largest is :" + largest);
        Console.WriteLine("Second Largest is :" + secondLargest);
        
    }
}
