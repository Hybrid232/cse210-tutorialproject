using System.ComponentModel;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _ref;

    public Scripture(Reference theRef, string currentWord)
    {
        _ref = theRef;

        string[] words = currentWord.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
        
    }
    public void HideRandomWords(int num)
    {
        Random ranWord = new Random();
                                //Here creates list of indices-----Here filters what is hidden------Changes the indices to a list
        List<int> leftoverWords = Enumerable.Range(0, _words.Count).Where(i => !_words[i].IsHidden()).ToList();

        leftoverWords = leftoverWords.OrderBy(i => ranWord.Next()).ToList();

        int hiddenWords = Math.Min(num, leftoverWords.Count());

        for (int i = 0; i < hiddenWords; i++)
        {
            _words[leftoverWords[i]].Hide();
        }

    }
    public bool IsAllHidden()
    {
        bool allHidden = _words.All(word => word.IsHidden());
        return allHidden;
    }
    public void GetDisplayContent()
    {
        string display = " ";
        foreach (Word word in _words)
        {
            display += word.TextDisplay() + " ";
        }
        
        Console.WriteLine(display.Trim());
    }
}