using System.Linq;

class Scripture
{
    // Attributes
    private string _verseString;
    private List<Word> _verseList;

    // Behaviors
    public Scripture(string verseString)
    {
        _verseString = verseString;
        _verseList = new List<Word>();
        string[] words = verseString.Split(" ");
        foreach (string w in words)
        {
            _verseList.Add(new Word(w));
        }
    }
    public void UpdateVerseString()
    {
        _verseString = string.Join(" ", _verseList.Select(word => word.GetDisplayText()));
    }
    public string GetVerseString()
    {
        return _verseString;
    }
    public void HideRandomVerseText()
    {
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _verseList.Count; i++)
        {
            if (!_verseList[i].IsHidden())
                visibleIndexes.Add(i);
        }
        Random random = new Random();
        int randomIndex = visibleIndexes[random.Next(visibleIndexes.Count)];
        _verseList[randomIndex].HideWord();
        UpdateVerseString();
    }
}