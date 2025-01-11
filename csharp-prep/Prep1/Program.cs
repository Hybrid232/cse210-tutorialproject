using System;

class Program
{
    static void Main(string[] args)
    {
        //Using Console.WriteLine will make the response enter, V.S. Console.Write keeps it on the same line//
        Console.Write("What is your first name: ");

        //let's user input their response then records it in the firstName variable//
        string firstName = Console.ReadLine();

        Console.Write("What is your last name: ");
        string lastName = Console.ReadLine();


        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}