using System;

class Program
{
    static void ActManager()
    {
        Console.WriteLine("     Main Menu");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. End Application");
        Console.WriteLine("");
        Console.Write("Select: ");
    }

    static void Main(string[] args)
    {
        bool repeatMenu = true;

        Console.WriteLine("Welcome to the Wellness Program! Enjoy some relaxing time!");
        Console.Write("Loading");
        for (int i = 0; i < 6; i++)
        {
            for (int i2 = 0; i2 < 4; i2++)
            {
                Console.Write(".");
                Thread.Sleep(100);
                if (i2 == 3)
                {
                    for (int i3 = 0; i3 < 4; i3++)
                    {
                        Console.Write("\b \b");
                        Thread.Sleep(100);
                    }  
                }
            }
            if (i == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("Load Complete! (-:");
                Thread.Sleep(1000);
                Console.Clear();
                break;  
            }
        } 

        while (repeatMenu)
        {
            ActManager();
            string uSelect = Console.ReadLine();
            Console.Clear();

            if (uSelect == "1")
            {
                BreathingAct breath = new BreathingAct("Here you will take a moment to take some relaxing deep breaths for you to feel better!", "Welcome to the Breathing Activity!", 0);
                breath.PresentInfo();
                breath.Run();
            }

            else if (uSelect == "2")
            {
                ReflectingAct refelct = new ReflectingAct("In this Activity, you will reflect on a question for you to ponder on.", "Welcome to the Reflecting Activity", 0);
                refelct.PresentInfo();
                refelct.GetRandomReflect();
                refelct.Run();
                
            }

            else if (uSelect == "3")
            {
                ListingAct list = new ListingAct("In this Activity, you will write as many things that relate to the question", "Welcome to the Listing Activity", 0);
                list.PresentInfo();
                list.GetRandomList();
                list.Run();
            }

            else if (uSelect == "4")
            {
                Console.Clear();
                Console.WriteLine("Hope you feel more relaxed after today! Goodbye!");
                repeatMenu = false;
            }

            else 
            {
                Console.Clear();
                Console.WriteLine("Wrong Input! Try again");
            }


        }

    }
}