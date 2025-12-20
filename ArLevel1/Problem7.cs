namespace ArLevel1;

public class Problem7
{
    public void EvenOdd()
    {
        int n = int.Parse(Console.ReadLine());
        
        if(n < 1)
        {
            Console.WriteLine("Not a natural number: ");
        }
        else
        {
            int[] even = new int[n / 2 + 1];
            int[] odd = new int[n / 2 + 1];

            int od = 0;
            int ev = 0;

            for (int i=1; i<n; i++)
            {
                if(i % 2 != 0)
                {
                    odd[od] = i;
                    //Console.WriteLine("Odd no " + odd[od]);
                    od++;
                }
                else
                {
                    even[ev] = i;
                    //Console.WriteLine("Even no " + even[ev]);
                    ev++;
                }
            }

            string oddArr = $"[{string.Join(", ", odd)}]";
            Console.WriteLine(oddArr);
            string evenArr = $"[{string.Join(", ", even)}]";
            Console.WriteLine(evenArr);
        }

        

    }
}
