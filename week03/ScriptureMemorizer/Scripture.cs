public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int count = 0;
        while (count < numberToHide && visibleWords.Count > 0)
        {
            int maxIndex = visibleWords.Count;
            int randomIndex = rand.Next(maxIndex);
            Word hiddenWord = visibleWords[randomIndex];
            hiddenWord.Hide();
            visibleWords.RemoveAt(randomIndex);
            count++;
        }
    }

    public string GetDisplayText()
    {
        List<String> texts = new List<string>();

        foreach (Word word in _words)
        {
            string display = word.GetDisplayText();
            texts.Add(display);
        }

        string combined = string.Join(" ", texts);
        string reference = _reference.GetDisplayText();
        string displayText = reference + " " + combined;
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }






}