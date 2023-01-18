using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Idaho Dunes RV";
        job1._jobTitle= "Manager";
        job1._startYear = 2016;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "BYUI";
        job2._jobTitle= "Surplus";
        job2._startYear = 2020;
        job2._endYear = 2022;

        //job1.Display();
        //job2.Display();
        
        Resume myResume = new Resume();
        myResume._name = "Quinn Bastian";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}