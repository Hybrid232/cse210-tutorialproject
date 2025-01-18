using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        }


        int listSum = 0;
        foreach (int value in inputNumbers)
        {
            listSum += value;
        }
        Console.WriteLine($"The Sum of your numbers is {listSum}");

        float listAverage = ((float)listSum) / inputNumbers.Count;
        Console.WriteLine($"The Average of your list is {listAverage}");


        int listMax = inputNumbers[0];

        foreach (int value in inputNumbers)
        {
            if (value > listMax)
            {
                listMax = value;
            }

        }
        Console.WriteLine($"The Max of your list is {listMax}");
    }   
}















        /* OLD CODE
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
        */


    