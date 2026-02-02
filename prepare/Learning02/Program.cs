using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyname = "SAS";
        job1._jobtitle = "Sales Manager";
        job1._startyear = 2005;
        job1._endyear = 2025;

        Job job2 = new Job();
        job2._companyname = "DoTerra";
        job2._jobtitle = "Smell Specialist";
        job2._startyear = 2011;
        job2._endyear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Soren Gomez";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

        

        



        
    }

}