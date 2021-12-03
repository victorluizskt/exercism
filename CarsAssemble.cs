using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed.Equals(0)) return 0;
        if(speed >= 1 && speed <= 4) return 1.0;
        if(speed > 4 && speed <= 8) return 0.9;
        if(speed.Equals(9)) return 0.8;
        if(speed.Equals(10)) return 0.77;
        return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return SuccessRate(speed) * (speed * 221);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        decimal productPerMinute = ((221.0M / 60.0M) * speed) * (decimal)SuccessRate(speed);
        return (int)productPerMinute;
    }
}
