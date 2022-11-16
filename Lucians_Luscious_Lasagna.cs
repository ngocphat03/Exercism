class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int x)
    {
        int y = ExpectedMinutesInOven();
        return y - x;
    }

    public int PreparationTimeInMinutes(int x)
    {
        int z = 2;
        return z * x;
    }

    public int ElapsedTimeInMinutes(int q, int w)
    {
        int c = PreparationTimeInMinutes(q);
        return c + w;
    }
}