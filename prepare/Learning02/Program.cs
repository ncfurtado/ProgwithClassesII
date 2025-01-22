using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        // Think of programming with classes as working with 'nouns.'
        // If you've got a program, talk about things in basic terms and 
        // then identify specifics like 'jobs' and 'resume'. Often these
        // nouns will be used as classes, and methods programmed around them.
        Job job1 = new Job();
        job1._company = "Microsoft Corporation";
        job1._jobTitle = "Intern";
        job1._startYear = 2015;
        job1._endYear = 2016;

        job1.Display();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Developer";
        job2._startYear = 2016;
        job2._endYear = 2017;


        Resume myResume = new Resume();
        myResume._name = "Daniel Game";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        

    }
}