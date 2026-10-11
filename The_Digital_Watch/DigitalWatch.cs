namespace The_Digital_Watch;

public class DigitalWatch
{
    public int Hours;
    public int Minutes;

    public DigitalWatch(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }
    
    public void AddTime(int minutesToAdd)
    {
        Minutes = Minutes + minutesToAdd;
        Hours = Hours + (Minutes / 60);
        Minutes = Minutes % 60;


    }

    public void DisplayTime()
    {
        Console.WriteLine(Hours + ":" + Minutes);
    }
}