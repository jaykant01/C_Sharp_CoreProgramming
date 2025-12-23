namespace Method_Level2;
/*Extend or Create a UnitConvertor utility class similar to the one shown in the notes to
do the following. Please define Non static methods for all the UnitConvertor class methods. E.g.
 */
public class NonStaticUnitConvertor
{
   
        public double ConvertYardsToFeet(double yards)
        {
            double yards2feet = 3 * yards;
            return yards2feet;
        }

        public double ConvertFeetToYards(double feet)
        {
            double feet2yards = 0.333333 * feet;
            return feet2yards;
        }

        public double ConvertInchesToMeter(double inches)
        {
            double inches2meters = 0.0254 * inches;
            return inches2meters;
        }

        public double ConvertMetersToInches(double meters)
        {
            double meters2inches = 39.3701 * meters;
            return meters2inches;
        }

        public double ConvertInchesCentiMeters(double inches)
        {
            double inches2cm = 2.54 * inches;
            return inches2cm;
        }
}
