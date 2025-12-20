namespace ArLevel1;

public class Problem2
{
    public void Compare()
    {
        int s = int.Parse(Console.ReadLine());
        int[] arr = new int[s];

        for (int i=0; i<s; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            
            // Check Positive or Negative
            if (arr[i] >= 0)
            {
                string eveOdd = (arr[i] % 2 == 0) ? "Even" : "Odd";
                Console.WriteLine("The number is Positive and " + eveOdd);
            }
            else
            {
                Console.WriteLine($"The number {arr[i]} is negative");
            }
        }

        string printArry = $"[{string.Join(", ", arr)}]";
        Console.WriteLine( printArry );

        if (arr[0] == arr[s - 1])
        {
            Console.WriteLine("first and last element are Equal");
        }else if (arr[0] > arr[s - 1])
        {
            Console.WriteLine("Array first element is greater");
        }
        else
        {
            Console.WriteLine("Array last element is greater");
        }


    }
}
