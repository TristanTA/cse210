class Reference
{
    // Attributtes
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;
    private string _reference;

    // Behaviors
    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        if (_endVerse.HasValue)
        {
            _reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            _reference = $"{_book} {_chapter}:{_startVerse}"; 
        }
    }
    public string GetReference()
    {
        return _reference;
    }
}