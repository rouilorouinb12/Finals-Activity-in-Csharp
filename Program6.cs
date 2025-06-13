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
        hour = totalMinutes / 60;
        minute = totalMinutes % 60;
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
            int borrowed = (Math.Abs(minute) + 59) / 60;
            hour -= borrowed;
            minute += borrowed * 60;
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
        int total1 = t1.hour * 60 + t1.minute;
        int total2 = t2.hour * 60 + t2.minute;
        return new Time(Math.Max(0, total1 - total2));
    }

    public static implicit operator Time(int totalMinutes)
    {
        return new Time(totalMinutes);
    }

    public static explicit operator int(Time t)
    {
        return t.hour * 60 + t.minute;
    }

    public override string ToString()
    {
        return String.Format("{0:D2}:{1:D2}", hour, minute);
    }
}
