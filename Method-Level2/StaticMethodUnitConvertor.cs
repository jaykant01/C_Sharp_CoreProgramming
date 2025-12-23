namespace Method_Level2;
/* Extend or Create a UnitConvertor utility class similar to the one shown in the notes to
do the following. Please define static methods for all the UnitConvertor class methods. E.g.
 */
public class StaticMethodUnitConvertor
{
    public static double convertFarhenheitToCelsius(double farhen)
    {
        double farhenheit2celsius = (farhen - 32) * 5 / 9 ;
        return farhenheit2celsius;
    }

    public static double convertCelsiusToFarhenheit(double celsius)
    {
        double celsius2farhenheit = (celsius * 9 / 5) + 32;
        return celsius2farhenheit;
    }

    public static double convertPoundsToKg(double pounds)
    {
        double pounds2kilograms = 0.453592 * pounds;
        return pounds2kilograms;
    }

    public static double convertKgToPounds(double kg)
    {
        double kilograms2pounds = 2.20462 * kg;
        return kilograms2pounds;
    }

    public static double convertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541 * gallons;
        return gallons2liters;
    }

    public static double convertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172 * liters;
        return liters2gallons;
    }

    
}
