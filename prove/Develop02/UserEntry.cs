public class UserEntry
{
    public string _writer;
    public string _date;
    public string _questionPrompt;
    public string _writerResponse;

    public void Display()
    {
        Console.WriteLine($"{_writer}'s log on {_date}");
        Console.WriteLine($"Question: {_questionPrompt}");
        Console.WriteLine("");
        Console.WriteLine($"Reponse: {_writerResponse}");
        Console.WriteLine("");
        Console.WriteLine("");
    }

    
}