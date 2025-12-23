namespace Method_Level1;

public class Chocolates
{
    public int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
    {
        int chocolatesEach = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        return new int[] { chocolatesEach, remainingChocolates };
    }
}
