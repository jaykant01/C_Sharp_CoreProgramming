namespace Method_Level1;

public class ReaminderAndQuotient
{
    public int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;   
        int remainder = number % divisor;  

        return new int[] { quotient, remainder };
    }
}
