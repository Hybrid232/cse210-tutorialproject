using System;

class Program
{
    static void Main(string[] args)
    {
         

        
        Random ranNum = new Random();
        int numSecret = ranNum.Next(1, 15);
        int playerInput = 0;

        while (playerInput != numSecret)
        {
            Console.Write("What is the Secret Number? ");
            
            playerInput = int.Parse(Console.ReadLine());
            

            if (playerInput != numSecret)
            {
                Console.WriteLine("Not Right, Try again");
            }

            if (playerInput > numSecret)
            {
                Console.WriteLine("Lower");
            }

            else if (playerInput < numSecret)
            {
                Console.WriteLine("Higher");
            }

            else if (playerInput == numSecret)
            {
                Console.Write("That's the Secret Number!");
                break;
            }
        }


    }
}