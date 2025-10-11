public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";

    protected int _points = 0;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public abstract void RecordEvent();
    public abstract bool IsComplete();

    virtual public string GetDetailsString()
    {
        string details = _shortName + ": " + _description + " - points dealt: " + Convert.ToString(_points) + ", complete?: " + Convert.ToString(IsComplete());
        return details;
    }

    public abstract int GetPoints();

    public abstract string GetStringRepresentation();

    public string getName()
    {
        return _shortName;
    }


}