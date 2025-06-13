using System;

struct Time
{
    private int hour;
    private int minute;


    public Time(int hour, int minute)
    {
        this.hour = hour;
        this.minute = minute;
    }

    public int Hour
    {
        get { return hour; }
    }

    public int Minute
    {
        get { return minute; }
    }

    public override string ToString()
    {
        return String.Format("{0:D2}:{1:D2}", hour, minute);
    }
}

class Program
{
    static void Main()
    {
        Time t1 = new Time(23, 45);
        Console.WriteLine("Hour: " + t1.Hour);
        Console.WriteLine("Minute: " + t1.Minute);
        Console.WriteLine("Formatted Time: " + t1.ToString());

        Time t2 = new Time(10, 5);
        Console.WriteLine("Formatted Time: " + t2);  
    }
}
