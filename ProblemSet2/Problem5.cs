namespace ProblemSet2;

public class Problem5
{
    public void AgeHeight(int age1 ,int age2, int age3, double ht1, double ht2, double ht3)
    {
        if(age1 < age2 && age1 < age3)
        {
            Console.WriteLine("Amar is the Youngest");
        }else if (age2 < age1 && age2 < age3)
        {
            Console.WriteLine("Akbar is the Youngest");
        }
        else
        {
            Console.WriteLine("Anthony is the Youngest");
        }
        
        
        if(ht1 > ht2 && ht1 > ht3)
        {
            Console.WriteLine("Amar is the Tallest");
        }else if(ht2 > ht1 && ht2 > ht3)
        {
            Console.WriteLine("Akbar is the Tallest");
        }else
        {
            Console.WriteLine("Anthony is the Tallest");
        }
    }
}
