class MathsAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathsAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Sections {_textbookSection} Problems {_problems}";
    }
}