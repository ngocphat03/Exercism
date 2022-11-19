using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double x = 0f;
        if(speed == 0) { x = 0f; }
        if((speed >= 1) && (speed <= 4)) { x = 1f; }
        if((speed >= 5) && (speed <= 8)) { x = 0.9f; }
        if(speed == 9) { x = 0.8f; }
        if(speed == 10) { x = 0.77f; }
        return x;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double production = 0;
        production = speed * 221 * SuccessRate(speed);
        return production;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int working = (int)ProductionRatePerHour(speed)/60 ;
        return working;
    }
}