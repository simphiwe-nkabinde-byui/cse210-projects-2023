class Video
{
    public string title;
    public string author;
    public int length;
    public List<Comment> comments = new List<Comment>();

    public Video(string titleString, string authorString, int lengthInt, List<Comment> commentList)
    {
        title = titleString;
        author = authorString;
        length = lengthInt;
        comments = commentList;
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}    Author: {author}    Length: {length}s");
    }
    public void DisplayComments()
    {
        foreach (Comment comment in comments)
        {
            comment.DisplayInfo();
        }
    }
}