using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;

public class InfoJournal
{
    public List<UserEntry> _enteries = new List<UserEntry>();
    
    public void JournalList()
    {
        Console.WriteLine($"Here are your Journal Log's! Enjoy!");
        Console.WriteLine("");

        foreach (UserEntry userLogs in _enteries)
        {
            userLogs.Display();
        }
    }

    public void SaveJournal()
    {

        Console.Write("What would you want to save todays enteries as: ");
        string fileName = Console.ReadLine();
        Console.WriteLine("Saving journal log... ");
        Console.WriteLine("");

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (UserEntry saveTXT in _enteries)
            {
                outputFile.WriteLine($"{saveTXT._writer}~{saveTXT._date}~{saveTXT._questionPrompt}~{saveTXT._writerResponse}");

                
            }
        }
    }
        
    public void LoadFile()
    {
        Console.WriteLine("What file do you want to access?");
        string loadNewFile = Console.ReadLine();
        Console.WriteLine("");

        string[] grabFile = System.IO.File.ReadAllLines(loadNewFile);

        foreach (string things in grabFile)
        {
            string[] parts = things.Split("~");

            string _writer = parts[0];
            string _date = parts[1];
            string _questionPrompt = parts[2];
            string _writerResponse = parts[3];

            Console.WriteLine($"{_writer} {_date}, {_questionPrompt} {_writerResponse}");
            Console.WriteLine("");
        }
    }  
}