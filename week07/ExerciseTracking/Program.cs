using System;

class Program
{
    static void Main(string[] args)
    {

        TrackingManaher trackingManager = new TrackingManaher();
        trackingManager.Start();

        Console.WriteLine("\nYour recorded activities:");
        foreach (var activity in trackingManager.GetActivities())
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}