public class BreathingAct : Activity
{

    public BreathingAct(string message, string name, int timer) : base(message, name, timer)
    {
        
    }


    public void Run()
    {
        int timeLength = GetTime();
        DateTime futureTime = DateTime.Now.AddSeconds(timeLength);

        ShowLoader();
        Console.Clear();
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Breath In..");
            Countdown(4, futureTime);
            Console.WriteLine("Now Hold!!!");
            Countdown(2, futureTime);
            Console.WriteLine("Aaaaaand Breath Out..");
            Countdown(5, futureTime);
        }

        Console.WriteLine($"Amazing Job! You have completed {timeLength} seconds! Hope you feel so much more relaxed!");
        Console.Write("Press ENTER to return to the menu ");
        Console.ReadLine();
        Console.Clear();
        ShowLoader();
        Console.Clear();
    }

}