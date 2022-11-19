using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] arrayOne = new [] {0, 2, 5, 3, 7, 8, 4};
        return arrayOne; 
    }

    public int Today()
    {
        int x = birdsPerDay.Length;
        int y = birdsPerDay[x-1];
        return y;
    }

    public int IncrementTodaysCount()
    {
        int z = birdsPerDay[birdsPerDay.Length - 1]++;
        return z; 
    }
 
    public bool HasDayWithoutBirds()
    {
        var boolennn = true;
        for(int i=0; i < birdsPerDay.Length; i++)
        {
            if(birdsPerDay[i] == 0)
            {    boolennn = true;
                break;}
            else
                boolennn = false;
        }
        return boolennn;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birdCounts = 0;
        for(int i=0; i<numberOfDays; i++)
        {
            birdCounts += birdsPerDay[i];
        }
        return birdCounts;
    }

    public int BusyDays()
    {
        int birdBusy = 0;
        for(int i=0; i<birdsPerDay.Length; i++)
        {
            if(birdsPerDay[i] >= 5)
                birdBusy++;
        }
        return birdBusy;
    }
}