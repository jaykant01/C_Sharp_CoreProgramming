namespace Method_Level1;

public class SimpleInterest
{
    public double CalculateSI(double principal, double rate, double time)
    {
        double si = (principal * rate * time) / 100;
        return si;
    }
}
