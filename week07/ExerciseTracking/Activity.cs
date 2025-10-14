public abstract class Activity
{
    protected int _minutes = 0;

    protected double _distance = 0;

    protected double _speed = 0;

    protected double _pace = 0;

    public Activity(int minutes, double distance)
    {
        _minutes = minutes;
        _distance = distance;
    }

    public abstract string GetSummary();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();




}