class Lasagna
{
    private int ExpectedMinutes = 40;
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return ExpectedMinutes;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesPast)
    {
        if(minutesPast <= 40)
        {
             return ExpectedMinutes-minutesPast;
        }else
        {
             return 0;
        }
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
  public int PreparationTimeInMinutes(int layer)
    {
       return 2*layer;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layer, int minutesPast)
    {
       return 2*layer + (minutesPast);
    }
}
