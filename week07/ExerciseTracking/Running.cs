public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int minutes, double distanceMiles)
       : base(date, minutes)
    {
        _distance = distanceMiles;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}







