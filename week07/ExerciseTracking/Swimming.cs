
public class Swimming : Activity
{
    double _laps = 0;
    public Swimming(int minutes, double distance) : base(minutes, distance)
    {
        _laps = distance;
        _distance = distance * 50 / 1000;
    }

    public override string GetSummary()
    {
        string summary = "";
        summary += DateTime.Now.ToString();
        string other = summary.Substring(0, 10);
        summary = other;


        summary += " Swimming (" + _minutes + " min)- laps: " + _laps.ToString() + " (" + GetDistance().ToString() + " km) Speed: " + Math.Round(GetSpeed(),2).ToString() + " kph, Pace: " + GetPace().ToString() + " min per km";
        return summary;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance /_minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes/_distance;
    }

}