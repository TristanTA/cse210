public class MathAssignment : Assignment
{
    // Attributes
    private string _textbookSection;
    private string _problems;

    // Constructor
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Behaviors
    public string GetHomeworkList()
    {
        return $"{_textbookSection}: {_problems}";
    }
}