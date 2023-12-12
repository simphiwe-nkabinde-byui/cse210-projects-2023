class Comment
{
    public string commenter;
    public string text;

    public Comment(string commenterName, string textString)
    {
        commenter = commenterName;
        text = textString;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($">   {commenter} - {text}");
    }
}