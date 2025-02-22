using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Rick", "bruh");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("Mr. Andersen", "Fractions","7.1", "1-12");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        WritingAssignment writingAssignment = new WritingAssignment("Brandon Sanderson","Mistborn", "Good Fiction");
        Console.WriteLine(writingAssignment.GetHomeworkList());
    }
} 