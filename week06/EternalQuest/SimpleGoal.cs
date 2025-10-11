public class SimpleGoal : Goal
{
    bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string representation = "goal name: " + _shortName + ",  description: " + _description + ", points eligable:" + _points + ", Complete?: " + Convert.ToString(_isComplete);
        return representation;
    }

    public override int GetPoints()
    {
        if (_isComplete == true)
        {
            return _points;
        }
        else
        {
            return 0;
        }
    }
}