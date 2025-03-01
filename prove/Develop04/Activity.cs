public class Activity
{
    // protected is like using private but allows classes that inherit from it to access them
    private string _startMessage;
    private string _name;
    private int _timer;

    public Activity(string message, string name, int time)
    {
        _startMessage = message;
        _name = name;
        _timer = time;
        
    }

    public void ShowLoader()
    {
        Console.WriteLine("");
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
                Console.WriteLine("Load Complete!");
                Thread.Sleep(1000);
                Console.WriteLine(""); 
            }
        }
    }
    public void PresentInfo()
    {
        Console.WriteLine($"***{_name}***");
        Thread.Sleep(1000);
        Console.WriteLine("");
        Console.WriteLine($"{_startMessage}");
        Thread.Sleep(2000);
        Console.WriteLine("");
    }

     public int GetTime()
    {
        Console.Write("How long would you like your session (in seconds)? ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int timeSelect) && timeSelect > 0)
            {
                return timeSelect;
            }
            Console.Write("Invalid input. Please enter a positive number: ");
        }
    }

    public void Countdown(int count, DateTime futureTime)
    {
        for (int i = count; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}