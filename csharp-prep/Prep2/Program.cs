using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade: ");
        string gradeValue = Console.ReadLine();
        int grade = int.Parse(gradeValue);

        string gradeLetter = "";
       

        if (grade >= 90)
        {
            gradeLetter = "A";
            
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"You got a {gradeLetter} in this class!");

        if (grade >= 70)
        {
            Console.WriteLine("And you passed!");
        }
        else
        {
            Console.WriteLine("Darn, better luck next time!");
        }
    }
}