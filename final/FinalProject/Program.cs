using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void MainMenu()
    {
        Console.WriteLine("1. Catalogue");
        Console.WriteLine("2. View Shopping Cart");
        Console.WriteLine("3. Personal Information");
        Console.WriteLine("4. Leave Store");
        Console.WriteLine("");
        Console.Write("Select: ");
    }
    static void Main(string[] args)
    {
        bool repeat = true;

        Console.WriteLine("Welcome to ManyItemsMart!");
        Console.WriteLine("Great to have you here today!");

        while(repeat)
        {
            MainMenu();
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Product productSelect = new Product();
                productSelect.GetProduce();
                Console.ReadLine();
            }
            else if (userInput == "2")
            {

            }
            else if (userInput == "3")
            {

            }
            else if (userInput == "4")
            {
                repeat = false;

            }
            else
            {

            }


        }
        
    }
}