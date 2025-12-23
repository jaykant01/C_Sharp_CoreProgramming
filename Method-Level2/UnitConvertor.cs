namespace Method_Level2;
/*Extend or Create a UnitConvertor utility class similar to the one shown in the notes to
do the following. Please define static methods for all the UnitConvertor class methods. E.g.
 */
public class UnitConvertor
{
    public static double KmToMiles(double km)
    {
        double km2miles = 0.621371 * km;
        return km2miles;
    }

    public static double MilesTokm(double miles)
    {
        double miles2km = 1.60934 * miles;
        return miles2km;
    }

    public static double MetersToFeet(double meters)
    {
        double meters2feet = 3.28084 * meters;
        return meters2feet;
    }

    public static double FeetTometers(double feet)
    {
        double feet2meters = 0.3048 * feet;
        return feet2meters;
    }
}
