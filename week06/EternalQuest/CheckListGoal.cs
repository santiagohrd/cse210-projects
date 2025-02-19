public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus): base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target) // Si alcanza el objetivo
        {
            Console.WriteLine($"Goal '{_shortName}' fully completed! You earned {_points + _bonus} points (including a {_bonus} bonus).");
        }
        else
        {
            Console.WriteLine($"Progress on '{_shortName}': {_amountCompleted}/{_target}. You earned {_points} points.");
        }
    }


    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }


    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }
}