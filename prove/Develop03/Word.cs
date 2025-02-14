using System.Reflection.Metadata.Ecma335;

public class Word 
{
    private string _currentWord;
    private bool _isHidden;

    public Word(string currentWord)
    {
        _currentWord = currentWord;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string TextDisplay()
    {
        if (_isHidden)
        {
            return new string('_', _currentWord.Length);
        }
        else
        {
            return _currentWord;
        }
    }
    
}