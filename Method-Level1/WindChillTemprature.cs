namespace Method_Level1;

public class WindChillTemprature
{
    public double CalculateWindChill(double temperature, double windSpeed)
    {
        double windChill = 35.74
                           + 0.6215 * temperature
                           + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);

        return windChill;
    }
}
