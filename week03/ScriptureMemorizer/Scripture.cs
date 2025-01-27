public class Scripture
{
    private List<Word> _words;

    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');

        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }
    
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            List<Word> visibleWords = _words.Where(word => !word.isHidden()).ToList();

            if (visibleWords.Count == 0)
                break; 

            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";

    }

    public bool isCompletelyHidden()
    {
        return _words.All(word => word.isHidden());
    }
}