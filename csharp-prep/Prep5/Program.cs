using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int sqrNum = SquareNumber(favNumber);
        
        
        DisplayResult(userName, sqrNum);
        
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string input = Console.ReadLine();

        return input;
    }


    static int PromptUserNumber()
    {
        Console.Write($"What is your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());

        return favNumber;
    }
    
    static int SquareNumber(int userNumber)
    {
        int sqr = userNumber * userNumber;

        return sqr;
    }

    static void DisplayResult(string input, int sqr)
    {
        Console.WriteLine($"{input}, the square root of your number is {sqr}!");


    }
}