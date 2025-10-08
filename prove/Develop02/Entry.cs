class Entry
{
    // Parameters
    public string _current_date;
    public string _entry;
    public string _prompt;
    public string _user_response;

    public string Write(List<string> promptList)
    {
        _prompt = GetPrompt(promptList);
        Console.WriteLine(_prompt);
        _current_date = DateTime.Today.ToString("yyy-MM-dd");
        _user_response = Console.ReadLine();
        _entry = $"-----\n{_current_date}\n{_prompt}\n{_user_response}\n-----";
        return _entry;
    }

    public string GetPrompt(List<string> promptList)
    {
        Random rand = new Random();
        int index = rand.Next(promptList.Count);
        _prompt = promptList[index];
        return _prompt;
    }

    public void Display(List<string> journal)
    {
        for (int i = 0; i < journal.Count; i++)
        {
            Console.WriteLine(journal[i]);
        }
    }
}