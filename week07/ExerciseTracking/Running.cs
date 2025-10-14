public class Running : Activity
{
    public Running(int minutes, double distance) : base(minutes, distance)
    {

    }
    
    public override string GetSummary()
    {
        string summary = "";
        summary += DateTime.Now.ToString();
        string other = summary.Substring(0, 10);
        summary = other;

        summary += " Running (" + _minutes + " min)- " + GetDistance().ToString() + " km) Speed: " + Math.Round(GetSpeed(),2).ToString()+ " kph, Pace: " + GetPace().ToString() + " min per km";
        return summary;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }
}