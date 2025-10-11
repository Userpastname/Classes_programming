public class ChecklistGoal : Goal
{

    int _amountCompleted = 0;
    int _target = 0;
    int _bonus = 0;

    public ChecklistGoal(int target, int bonus, string name, string description, int points) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        string representation = "";
        if (IsComplete() == false)
        {
            representation = "goal name: " + _shortName + ",  description: " + _description + ", Progress: " + Convert.ToString(_amountCompleted) + "/" + Convert.ToString(_target) + ", points rewarded: " + Convert.ToString(_amountCompleted * _points);
        }
        else if (IsComplete() == true)
        {
            representation = "goal name: " + _shortName + ",  description: " + _description + ", Progress: " + Convert.ToString(_amountCompleted) + "/" + Convert.ToString(_target) + ", points rewarded: " + Convert.ToString((_amountCompleted * _points) + _bonus);
        }
        return representation;
    }

    public override string GetDetailsString()
    {
        string details = _shortName + ": " + _description + " - points dealt - " + Convert.ToString(_points) + " - bonus completion points - " + Convert.ToString(_bonus);
        return details;
    }

    public override int GetPoints()
    {
        int points = 0;
        points += _amountCompleted * _points;
        if (IsComplete() == true)
        {
            points += _bonus;
        }

        return points;
    }
}