using System;

struct Time
{
    private int hour;
    private int minute;

    public Time(int hour, int minute)
    {
        this.hour = hour;
        this.minute = minute;
        NormalizeTime();
    }

    public Time(int totalMinutes)
    {
        this.hour = totalMinutes / 60;
        this.minute = totalMinutes % 60;
        NormalizeTime();
    }

    public int Hour => hour;
    public int Minute => minute;

    private void NormalizeTime()
    {
        if (minute >= 60)
        {
            hour += minute / 60;
            minute %= 60;
        }
        else if (minute < 0)
        {
            int borrowedHours = (Math.Abs(minute) + 59) / 60;
            hour -= borrowedHours;
            minute += borrowedHours * 60;
        }

        if (hour < 0)
        {
            hour = 0;
            minute = 0;
        }
    }

    public static Time operator +(Time t1, Time t2)
    {
        return new Time(t1.hour + t2.hour, t1.minute + t2.minute);
    }

    public static Time operator -(Time t1, Time t2)
    {
        int totalMinutes1 = t1.hour * 60 + t1.minute;
        int totalMinutes2 = t2.hour * 60 + t2.minute;
        return new Time(Math.Max(0, totalMinutes1 - totalMinutes2));
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
        Time t1 = new Time(1, 40);     
        Time t2 = new Time(2, 30);    

        Time sum = t1 + t2;
        Time diff = t2 - t1;

        Console.WriteLine("t1: " + t1);        
        Console.WriteLine("t2: " + t2);       
        Console.WriteLine("Sum: " + sum);     
        Console.WriteLine("Diff: " + diff);    

        Time t3 = new Time(75);
        Console.WriteLine("Time from 75 minutes: " + t3);  
    }
}
