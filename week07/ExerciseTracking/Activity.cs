public abstract class Activity
{
    private string _date;
    private int _duration; 

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public int GetDuration() => _duration;
    public string GetDate() => _date;

    public abstract double GetDistance();
    public virtual double GetSpeed() => (GetDistance() / _duration) * 60;
    public virtual double GetPace() => _duration / GetDistance();

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_duration} min): " +
               $"Distance: {GetDistance():0.1f} km, " +
               $"Speed: {GetSpeed():0.1f} kph, " +
               $"Pace: {GetPace():0.2f} min per km";
    }
}   