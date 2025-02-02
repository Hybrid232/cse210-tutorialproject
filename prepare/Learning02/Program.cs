using System;

class Program
{

    static void DisplayMenu()
    {
        Console.WriteLine("Menu: ");
        Console.WriteLine("1. Add New Job");
        Console.WriteLine("2. Add Resume");
        Console.WriteLine("3. Quit");
        Console.WriteLine();
    
    }
    static void Main(string[] args)
    {
        //#1 Add new Job
        //#2 Display Resume
        //#3 Quit
        Resume theResume = new Resume();

        bool keepRunning = true;

        while (keepRunning)
        {
            DisplayMenu();
            Console.Write("Enter Selection: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                //Company Name
                Console.Write("What is the name of the company: ");
                string company = Console.ReadLine();

                //Company Position
                Console.Write("What was your position: ");
                string position = Console.ReadLine();

                //Start Company
                Console.Write("What year did you start: ");
                int startyr = int.Parse(Console.ReadLine());

                //End Company
                Console.Write("What year did you leave: ");
                int endyr = int.Parse(Console.ReadLine());

                Job newJob = new Job();
                newJob._jobCompany = company;
                newJob._jobTitle = position;
                newJob._startYear = startyr;
                newJob._endYear = endyr; 

                theResume._resumes.Add(newJob);
            }

            else if (userChoice == "2")
            {
                //Display Resume
                theResume.JobList();
            }

            else if (userChoice == "3")
            {
                //Quit
                keepRunning = false;
            }

            else
            {
                //Wrong input
                Console.WriteLine("Sorry, Wrong Input");
            }

        }






        /*
        Resume appNameOne = new Resume();
        appNameOne._personName = "Jake Farm";


        Job firstJob = new Job();
        firstJob._jobTitle = "OPD Worker";
        firstJob._jobCompany = "Walmart";
        firstJob._startYear = 2022;
        firstJob._endYear = 2023;

        Job secondJob = new Job();
        secondJob._jobTitle = "Programmer";
        secondJob._jobCompany = "Google";
        secondJob._startYear = 2025;
        secondJob._endYear = 2030;

        appNameOne.JobList();
        firstJob.JobDisplay();
        secondJob.JobDisplay();
        */
        
    }
}