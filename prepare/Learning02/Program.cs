using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Crew member";
        job1._company = "Mcdonalds";
        job1._startYear = 2019;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "cashier";
        job2._company = "Lowes";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Tyler Day";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}