using System.Runtime.CompilerServices;

class Word
{
    // Attributes
    private string _word;
    private bool _isHidden;
    private string _visibleText;

    // Behaviors
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
        _visibleText = word;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public void HideWord()
    {
        _isHidden = true;
        _visibleText = new string('_', _word.Length);
    }
    public string GetDisplayText()
    {
        return _visibleText;
    }
}