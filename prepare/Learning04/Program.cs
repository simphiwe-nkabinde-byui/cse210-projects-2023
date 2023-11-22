using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Math Assignment");
        MathsAssignment mathsAssignment = new MathsAssignment("Peter Jacobson", "BODMAS", "3.7", "8-12");
        string mathsSummary = mathsAssignment.GetSummary();
        string homeworkList = mathsAssignment.GetHomeworkList();
        Console.WriteLine(mathsSummary);
        Console.WriteLine(homeworkList);

        Console.WriteLine("Writitng Assignment");
        WritingAssignment writingAssignment = new WritingAssignment("Holly Myburg", "Poetry", "The leaves always fall");
        string writingSummary = writingAssignment.GetSummary();
        string writingInformation = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingSummary);
        Console.WriteLine(writingInformation);
    }
}