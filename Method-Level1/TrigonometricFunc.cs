namespace Method_Level1;

public class TrigonometricFunc
{
    public double[] calculateTrigonometricFunctions(double angle)
    {
        // Convert degrees to radians
        double radians = angle * Math.PI / 180;

        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }
}
