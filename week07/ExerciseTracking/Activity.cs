using System.Globalization;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;


    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string dateText = GetDate().ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        string activity = this.GetType().Name;
        int duration = GetMinutes();
        double distance = GetDistance();
        string distanceText = distance.ToString("0.0");
        double speed = GetSpeed();
        string speedText = speed.ToString("0.0");
        double pace = GetPace();
        string paceText = pace.ToString("0.00");
        string summary = dateText + " " + activity + " (" + duration + " min): "
                     + "Distance: " + distanceText + " miles, "
                     + "Speed: " + speedText + " mph, "
                     + "Pace: " + paceText + " min per mile";

        return summary;
    }
}