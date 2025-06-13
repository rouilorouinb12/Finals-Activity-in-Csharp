using System;

struct Time
{
    private readonly int totalMinutes;

    public Time(int hours, int minutes)
    {
        totalMinutes = hours * 60 + minutes;
    }

    public Time(int minutes)
    {
        totalMinutes = minutes;
    }

    public int Hour
    {
        get { return totalMinutes / 60; }
    }

    public int Minute
    {
        get { return totalMinutes % 60; }
    }

    public override string ToString()
    {
        return String.Format("{0:D2}:{1:D2}", Hour, Minute);
    }
}

class Program
{
    static void Main()
    {
        Time t = new Time(23, 45);

        Console.WriteLine("Hour: " + t.Hour);     
        Console.WriteLine("Minute: " + t.Minute);
        Console.WriteLine("Formatted Time: " + t); 

        Time t2 = new Time(605);  
        Console.WriteLine("t2 = " + t2);         
    }
}