class File
{
    // Parameters
    public string _fileName;

    public void Save(List<string> journal)
    {
        Console.WriteLine("What file do you want to save your journal to?");
        _fileName = Console.ReadLine();
        System.IO.File.AppendAllLines(_fileName, journal);
        Console.WriteLine($"Journal saved at {_fileName}");
    }

    public List<string> Load(string fileName)
    {
        List<string> journal = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int entrySize = 5;
        for (int i = 0; i < lines.Length; i += entrySize)
        {
            string entry = string.Join("\n", lines, i, Math.Min(entrySize, lines.Length - i));
            journal.Add(entry);
        }
        return journal;
    }
}