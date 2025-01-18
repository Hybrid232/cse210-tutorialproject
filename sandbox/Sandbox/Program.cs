using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        The names of the variable
        GOod stuff
        */

        string adjName = GetAdjective();
        string nounName = GetNoun();

        int number = Multiply(3, 4);

        Console.WriteLine($"I looked out the window and saw {number} {adjName} {nounName}s!");
    }

        static int Multiply(int number1, int number2)
        {
            int product = number1 * number2;

            return product;
        }
        static string GetAdjective()
        {
            List<string> words = new List<string>();
            words.Add("Blue");
            words.Add("Yellow");
            words.Add("Big");
            words.Add("Small");

            string adjName = words[2];

            return adjName;    
        }

        static string GetNoun()
        {
            string nounName = "bird";

            return nounName;
        }
}