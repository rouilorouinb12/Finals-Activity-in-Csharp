﻿using System;

public struct Time
{
    private readonly int minutes;

    public Time(int hh, int mm)
    {
        this.minutes = 60 * hh + mm;
    }

    public override string ToString()
    {
        return minutes.ToString();
    }
}

class Program
{
    static void Main()
    {
        Time time1 = new Time(10, 5);   
        Time time2 = new Time(0, 45);   

        Console.WriteLine("Time 1: " + time1);
        Console.WriteLine("Time 2: " + time2);
    }
}
