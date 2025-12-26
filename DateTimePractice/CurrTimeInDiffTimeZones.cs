namespace DateTimePractice;
/* Write a program that displays the current time in different time zones:
 */
public class CurrTimeInDiffTimeZones
{
    public void DisplayTimeZones()
    {
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        TimeZoneInfo gmtZone = TimeZoneInfo.Utc;
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime, gmtZone);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);

        Console.WriteLine("Current Time in Different Time Zones");
        Console.WriteLine("GMT : " + gmtTime);
        Console.WriteLine("IST : " + istTime);
        Console.WriteLine("PST : " + pstTime);
    }
    
}
