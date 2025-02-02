using System;
using System.IO;

class Program
{
    //Main Menu Text
    static void MainMenu()
    {
        Console.WriteLine("Main Menu:");
        Console.WriteLine("1. New Enrty");
        Console.WriteLine("2. Display Entry");
        Console.WriteLine("3. Save Entry");
        Console.WriteLine("4. Load Entry");
        Console.WriteLine("5. Quit Application");
        Console.WriteLine("");
    }
    //

    static void Main(string[] args)
    {
        //Main Loop Bool
        bool runProgram = true;
        //
        //Journal List
        InfoJournal journal = new InfoJournal();


        //Welcome Text
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Entry System!");
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine($"Welcome {userName}! What would you like to do?");
        Console.WriteLine("");
        //

        //Main While Loop
        while (runProgram)
        {
            //Display Main Menu
            MainMenu();
            Console.Write("Select: ");
            string userChoice = Console.ReadLine();
            //

            //
            UserEntry journalWrite = new UserEntry();
            //1. New Entry
            if (userChoice == "1")
            {
                //Set prompt variables
                string promptChoice = "";
                string prompt = "";
                PromptGenerator randPrompt = new PromptGenerator();
                //

                //If user doesn't like first prompt
                while (promptChoice != "1" )
                {
                    //Creates the new random prompt
                    prompt = randPrompt.RandomPrompt();
                    //

                    //Displays the new Prompt
                    Console.WriteLine("");
                    Console.WriteLine(prompt);
                    Console.WriteLine("");
                    //
                    
                    //Ask User if they want to keep it or have a new one
                    Console.WriteLine("Keep this Prompt or choose a new one: ");
                    Console.WriteLine("1. Keep Prompt");
                    Console.WriteLine("2. New Prompt");
                    Console.Write("Select: ");
                    promptChoice = Console.ReadLine();
                    //
            
                }
                //
                
                //User Writing
                Console.WriteLine("");
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Console.WriteLine(dateText);
                
                Console.WriteLine($"What is your response to this question: {prompt}");
                string userJournalEntry = Console.ReadLine();
                Console.WriteLine("");


                journalWrite._writer = userName;
                journalWrite._date = dateText;
                journalWrite._questionPrompt = prompt;
                journalWrite._writerResponse = userJournalEntry;

                journal._enteries.Add(journalWrite);
            }
            //

            //2. Display Entry
            else if (userChoice == "2")
            {
                journal.JournalList();

            }

            //3. Save Entry
            else if (userChoice == "3")
            {
                journal.SaveJournal();

            }

            //4. Load Entry
            else if (userChoice == "4")
            {
                journal.LoadFile();

            }

            //5. End Program
            else if (userChoice == "5")
            {
                //Ends While Loop
                Console.WriteLine("");
                Console.WriteLine("Thanks for writing in your journal today! Goodbye!");
                runProgram = false;
                //
            }

            else
            {
                //If User inputs wrong input
                Console.WriteLine("");
                Console.WriteLine("Invalid Input. Try again.");
                Console.WriteLine("");
                //
            }
        }
        //
    }
}