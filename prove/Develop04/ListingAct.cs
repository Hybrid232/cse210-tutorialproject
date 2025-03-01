public class ListingAct : Activity
{
    private List<string> _listingPrompts = new List<string>();
    private int _countResponse;
    
    public ListingAct(string message, string name, int time) : base(message, name, time)
    {
        _countResponse = 0;
    }

    public void GetRandomList()
    {
        _listingPrompts.Add("What was something you did that was really hard today?");
        _listingPrompts.Add("When have you felt joy this month?");
        _listingPrompts.Add("Who make you feel happy and why?");
        _listingPrompts.Add("How can you make someone else smile?");
        _listingPrompts.Add("What is you most favorite thing to do and why?");
        _listingPrompts.Add("What is something you are struggling with?");
        _listingPrompts.Add("When did you feel the Spirit today?");
        _listingPrompts.Add("How have you seen the Lord's hand today?");

    }

    public void Run()
    {
        Random randy = new Random();
        int refelctIndex = randy.Next(_listingPrompts.Count());

        int timeLength = GetTime();
        DateTime futureTime = DateTime.Now.AddSeconds(timeLength);
        Console.Clear();
        ShowLoader();
        Console.Clear();

        Console.WriteLine(_listingPrompts[refelctIndex]);

        while (DateTime.Now < futureTime)
        {
            Console.Write(">>> ");
            Console.ReadLine();
            _countResponse++;
        }
    
        Console.WriteLine($"You had written a total of: {_countResponse} responses");
        Console.WriteLine("");
        Console.WriteLine("Great Job!");
        Console.WriteLine($"You have completed {timeLength} seconds! Hope you feel so much more relaxed!");
        Console.Write("Press ENTER to return to the menu ");
        Console.ReadLine();
        Console.Clear();
        ShowLoader();
        Console.Clear();




    }
}