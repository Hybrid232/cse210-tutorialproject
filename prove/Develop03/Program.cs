using System;

class Program
{
    static void MainMenu()
    {
        Console.WriteLine("Which scripture would you want to choose?");
        Console.WriteLine("1- Alma 7:11");
        Console.WriteLine("2- Helaman 5:12");
        Console.WriteLine("3- James 1:5");
        Console.WriteLine("4- Mosiah 16:9");
        Console.WriteLine("5- Quit Session");
    }

    static void Main(string[] args)
    {
        bool repeatMenu = true;
        Console.WriteLine("Welcome to the Scriptrue Memorizer!");
        Console.WriteLine("ENTER to go to the Main Menu!");
        Console.ReadLine();
        Console.Clear();

        while (repeatMenu)
        {
            MainMenu();
            Console.Write("Select: ");
            string userSelect = Console.ReadLine();
            Console.Clear();

            if (userSelect == "1")
            {
                bool repeatAlma = true;
                Reference AlmaRef = new Reference("Alma", 7, 11);
                Scripture AlmaScript = new Scripture(AlmaRef, "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.");
                
                while (repeatAlma == true) 
                {
                    Console.Write(AlmaRef.GetDisplayContent());
                    AlmaScript.GetDisplayContent();
                    Console.WriteLine("");

                    if (AlmaScript.IsAllHidden())
                    {
                        Console.WriteLine("That's the whole scripture! Press ENTER to go back to the menu! Good Job!");
                        Console.ReadLine();
                        repeatAlma = false;
                        Console.Clear();
                        continue;
                    }

                    Console.WriteLine("ENTER to memorize more OR press 1 to go back to the menu");
                    string userAlmaInput = Console.ReadLine();
                    Console.Clear();
                    
                    if (userAlmaInput == "1")
                    {
                        Console.Clear();
                        repeatAlma = false;
                    }
                    else
                    {
                        AlmaScript.HideRandomWords(3);
                    }
                }

            }
            else if (userSelect == "2")
            {
                bool repeatHelaman = true;
                Reference HelamanRef = new Reference("Helaman", 5, 12);
                Scripture HelamanScript = new Scripture(HelamanRef, "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");

                while (repeatHelaman)
                {
                    Console.Write(HelamanRef.GetDisplayContent());  
                    HelamanScript.GetDisplayContent();
                    Console.WriteLine("");

                    if (HelamanScript.IsAllHidden())
                    {
                        Console.WriteLine("That's the whole scripture! Press ENTER to go back to the menu! Good Job!");
                        Console.ReadLine();
                        repeatHelaman = false;
                        Console.Clear();
                        continue;
                    }

                    Console.WriteLine("ENTER to memorize more OR press 1 to go back to the menu");
                    string userHelamanInput = Console.ReadLine();
                    Console.Clear();

                    if (userHelamanInput == "1")
                    {
                        Console.Clear();
                        repeatHelaman = false;
                    }
                    else
                    {
                        HelamanScript.HideRandomWords(3);
                    }
                    


                }
            }
            else if (userSelect == "3")
            {
                bool repeatJames = true;
                Reference JamesRef = new Reference("James", 1, 5);
                Scripture JamesScript = new Scripture(JamesRef, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.");
                
                while (repeatJames)
                {
                    Console.Write(JamesRef.GetDisplayContent());
                    JamesScript.GetDisplayContent();
                    Console.WriteLine("");

                    if (JamesScript.IsAllHidden())
                    {
                        Console.WriteLine("That's the whole scripture! Press ENTER to go back to the menu! Good Job!");
                        Console.ReadLine();
                        repeatJames = false;
                        Console.Clear();
                        continue;
                    }
                    
                    Console.WriteLine("ENTER to memorize more OR press 1 to go back to the menu");
                    string userJamesInput = Console.ReadLine();
                    Console.Clear();

                    if (userJamesInput == "1")
                    {
                        Console.Clear();
                        repeatJames = false;
                    }
                    else
                    {
                        JamesScript.HideRandomWords(3);
                    }


                }
            }
            else if (userSelect == "4")
            {
                bool repeatMosiah = true;
                Reference MosiahRef = new Reference("Mosiah", 16, 9);
                Scripture MosiahScript = new Scripture(MosiahRef, "He is the light and the life of the world; yea, a light that is endless, that can never be darkened; yea, and also a life which is endless, that there can be no more death.");
                
                while (repeatMosiah)
                {
                    Console.Write(MosiahRef.GetDisplayContent());
                    MosiahScript.GetDisplayContent();
                    Console.WriteLine("");

                    if (MosiahScript.IsAllHidden())
                    {
                        Console.WriteLine("That's the whole scripture! Press ENTER to go back to the menu! Good Job!");
                        Console.ReadLine();
                        repeatMosiah = false;
                        Console.Clear();
                        continue;
                    }

                    Console.WriteLine("ENTER to memorize more OR press 1 to go back to the menu");
                    string userMosiahInput = Console.ReadLine();
                    Console.Clear();
                    
                    if (userMosiahInput == "1")
                    {
                        Console.Clear();
                        repeatMosiah = false;
                    }
                    else
                    {
                        MosiahScript.HideRandomWords(3);
                    }
                }

            }
            else if (userSelect == "5")
            {
                Console.WriteLine("");
                Console.Clear();
                Console.WriteLine("Remember God loves you! Thanks!");
                repeatMenu = false; 

            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Sorry, Wrong Input");
            }
        }
    }
}