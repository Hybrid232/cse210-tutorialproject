public class ReflectingAct : Activity
{
    private List<string> _reflectPrompts = new List<string>();
    private List<string> _ponderQuestions = new List<string>();
    
    public ReflectingAct(string message, string name, int time) : base(message, name, time)
    {
        
    }

    public void GetRandomReflect()
    {
        _reflectPrompts.Add("When have you seen Joy today?");
        _reflectPrompts.Add("Who has impacted you the most?");
        _reflectPrompts.Add("What is the most important thing to you?");
        _reflectPrompts.Add("How have you helped someone this month?");

        Console.WriteLine("When you are ready, press ENTER for your prompt");
        Console.ReadLine();
        Console.Clear();
        ShowLoader();
        Console.Clear();

        Console.WriteLine("Think for a moment and reflect on this question:");
        Random randy = new Random();
        int refelctIndex = randy.Next(_reflectPrompts.Count());
        Console.WriteLine($"======{_reflectPrompts[refelctIndex]}======");
        Console.WriteLine("");

    }


    public void Run()
    {
        int timeLength = GetTime();
        DateTime futureTime = DateTime.Now.AddSeconds(timeLength);

        _ponderQuestions.Add(">>> How did that change you?");
        _ponderQuestions.Add(">>> What did you learn from this experience?");
        _ponderQuestions.Add(">>> Who would you want to share this with?");
        _ponderQuestions.Add(">>> Why was that so impactful for you?");
        _ponderQuestions.Add(">>> What challenges might you face in applying this learning?");
        _ponderQuestions.Add(">>> What specific actions could you take to implement what you learned?");
        _ponderQuestions.Add(">>> Can you think of a similar situation where this knowledge could be useful?");
        _ponderQuestions.Add(">>> How did this experience change your perspective?");
        _ponderQuestions.Add(">>> What further questions do you have about this topic?");
        _ponderQuestions.Add(">>> How can you measure your progress in applying this moment?");
       

        Console.Clear();
        ShowLoader();
        Console.Clear();
        while (DateTime.Now < futureTime)
        {
            Random randy = new Random();
            int ponderIndex = randy.Next(_ponderQuestions.Count());
            Console.WriteLine(_ponderQuestions[ponderIndex]);
            Countdown(5, futureTime);
        }

        Console.WriteLine("Great Job!");
        Console.WriteLine($"You have completed {timeLength} seconds! Hope you feel so much more relaxed!");
        Console.Write("Press ENTER to return to the menu ");
        Console.ReadLine();
        Console.Clear();
        ShowLoader();
        Console.Clear();

    }
}