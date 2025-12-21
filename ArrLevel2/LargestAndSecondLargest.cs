namespace ArrLevel2;

public class LargestAndSecondLargest
{
    public void Largest()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        int largest = int.MinValue;
        int secondLargest = largest;

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

            }else if (secondLargest < largest && secondLargest > arr[i] )
            {
                secondLargest = arr[i];
            }
        }

        Console.WriteLine("Largest is :" + largest);
        Console.WriteLine("Second Largest is :" + secondLargest);
        
    }
}
