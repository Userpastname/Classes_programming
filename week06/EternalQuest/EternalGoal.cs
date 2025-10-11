public class EternalGoal : Goal
{
    int _amountCompleted;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _amountCompleted = 0;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        string representation = "goal name: " + _shortName + ",  description: " + _description + ", points per:" + _points + ", amount completed: " + Convert.ToString(_amountCompleted) + ", total points:" + Convert.ToString(_amountCompleted * _points);
        return representation;
    }
    
    public override int GetPoints()
    {
        return _points*_amountCompleted;
    }
}