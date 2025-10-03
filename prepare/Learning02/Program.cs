using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2004;
        job1._endYear = 2012;

        Job job2 = new Job();
        job2._jobTitle = "Human Factors Engineer";
        job2._companyName = "Meta";
        job2._startYear = 2020;
        job2._endYear = 2025;

        Resume resume1 = new Resume();
        resume1._name = "Tristan Allen";
        resume1._jobs = new List<Job> { job1, job2 };
        resume1.DisplayResume(); 
    }
}