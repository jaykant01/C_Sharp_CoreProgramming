namespace Method_Level1;

public class AthleteRun
{
    public double CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        double rounds = 5000 / perimeter;
        return rounds;
    }
}
