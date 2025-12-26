namespace Method_Level3;
/* Write a program Euclidean distance between two points as well as the equation of
the line using those two points. Use Math functions Math.Pow() and Math.Sqrt()
 */
public class GeometryUtil
{
    public static double FindDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(
            Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)
        );

        return Math.Round(distance, 2);
    }

    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1);   
        double b = y1 - m * x1;            

        return new double[]
        {
            Math.Round(m, 2),
            Math.Round(b, 2)
        };
    }
}
