using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Console.Write("");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2010;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Data analyst";
        job2._startYear = 2016;
        job2._endYear = 2025;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();


    }
}