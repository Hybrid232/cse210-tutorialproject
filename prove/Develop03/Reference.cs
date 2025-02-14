using System.Collections.Concurrent;
using System.ComponentModel;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;

    }
    public string GetDisplayContent()
    {
        string userScript = $"{_book} {_chapter}:{_startVerse}- ";
        return userScript;
    }
}