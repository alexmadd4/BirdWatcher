using System;
using System.Linq;

public class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Any(count => count == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        return birdsPerDay.Take(numberOfDays).Sum();
    }

    public int BusyDays()
    {
        return birdsPerDay.Count(count => count >= 5);
    }
}

class Program
{
    static void Main()
    {
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        
        Console.Write("Last Week's Count: [");
        int[] lastWeekCount = BirdCount.LastWeek();
        for (int i = 0; i < lastWeekCount.Length; i++)
        {
            Console.Write(lastWeekCount[i]);
            if (i < lastWeekCount.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
        Console.WriteLine("Today's bird count: " + birdCount.Today());
        birdCount.IncrementTodaysCount();
        Console.WriteLine("After incrementing today's count: " + birdCount.Today());
        Console.WriteLine("Has day without birds: " + birdCount.HasDayWithoutBirds());
        Console.WriteLine("Count for the first days: " + birdCount.CountForFirstDays(4));
        Console.WriteLine("Number of busy days: " + birdCount.BusyDays());

    }
}