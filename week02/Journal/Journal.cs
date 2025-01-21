public class Journals
{
    public List<Entry> _entriesList = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entriesList.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entriesList)
        {
            Console.WriteLine(" ");
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entriesList)
            {
                outputFile.WriteLine($"{entry._date}, Prompt: {entry._promptText}, {entry._entryText}");   
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entriesList.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if  (parts.Length == 3)
            {
                string entryDate = parts[0];
                string prompt = parts[1];
                string entryText = parts[2];


                Entry entry = new Entry
                {
                    _date = entryDate,
                    _promptText = prompt,
                    _entryText = entryText
                };

                _entriesList.Add(entry);
            }
        }
    }
}