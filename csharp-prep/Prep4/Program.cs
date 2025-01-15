using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> inputNumbers = new List<int>();
        Console.WriteLine("Make a list of as many numbers as you want! Press 0 when finished.");
        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Input Number: ");
            userInput = int.Parse(Console.ReadLine());
            inputNumbers.Add(userInput);
            

            if (userInput == 0)
            {
                int listSum = inputNumbers.AsQueryable().Sum();
                double listAverage = Queryable.Average(inputNumbers.AsQueryable());
                int listMax = inputNumbers.Max();
                
                Console.WriteLine($"Sum: {listSum}");
                Console.WriteLine($"Average: {listAverage}");
                Console.WriteLine($"Highest Number: {listMax}");
            }
        }
        


    }
}