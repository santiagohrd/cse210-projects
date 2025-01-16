using System.Diagnostics.Contracts;

public class Resume
{
    public string _name = "Santiago Herrera";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            Console.WriteLine($"{job._jobTitle} ({job._company}) {job._startYear}-{job._endYear}");

        }
    }
}