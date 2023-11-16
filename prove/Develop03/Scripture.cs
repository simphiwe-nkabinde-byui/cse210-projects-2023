class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture()
    {
        // pick random scripture from file
        Random random = new Random();
        string[] lines = System.IO.File.ReadAllLines("scriptures.txt");
        int randomIndex = random.Next(0, lines.Length);
        string randomScripture = lines[randomIndex];
        string[] scriptureArr = randomScripture.Split("|");

        //populate word List
        foreach (string wordString in scriptureArr[1].Split())
        {
            Word word = new Word(wordString);
            _words.Add(word);
        }
        // create reference
        string[] referenceText = scriptureArr[0].Split(" ");
        _reference = new Reference(referenceText[0], int.Parse(referenceText[1]), int.Parse(referenceText[2]));
    }
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string wordString in text.Split())
        {
            Word word = new Word(wordString);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 1; i < numberToHide; i++)
        {
            int randomIndex = random.Next(0, _words.Count);
            _words[randomIndex].Hide();
        }
    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += " " + word.GetDisplayText();
        }
        return $"{referenceText} {scriptureText}";
    }
    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}