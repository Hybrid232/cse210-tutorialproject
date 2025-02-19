using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Mark Stevenson", "Addition");
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine("");

        MathAssignment assignment2 = new MathAssignment("Jerome Stevenson", "Subtraction", "5.5", "15-20");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        Console.WriteLine("");

        WritingAssignment assignment3 = new WritingAssignment("Iris Stevenson", "Religious History", "Writings of Ancient Prophets");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());
        
    }
}