namespace Method_Level1;

public class HandShakes
{
    public int CalculateHandshakes(int n)
    {
        int handshakes = (n * (n - 1)) / 2;
        return handshakes;
    }
}
