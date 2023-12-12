abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string checkMark = IsComplete() ? "X" : " ";
        return $"[{checkMark}] {_shortName} ({_description})"; ;
    }
    public string GetGoalName()
    {
        return _shortName;
    }
    public abstract string GetStringRepresentaion();
    public void ShowCelebrationAnimation()
    {
        string[] characters = { "C", "O", "N", "G", "R", "A", "T", "U", "L", "A", "T", "I", "O", "N", "S", "!" };
        for (int i = 0; i < characters.Length; i++)
        {
            Thread.Sleep(250);
            Console.Write(characters[i]);
        }
        Console.WriteLine();
        DrawStar();
    }
    public void DrawStar()
    {
        Console.WriteLine("|                /\\");
        Console.WriteLine("|               /  \\");
        Console.WriteLine("|              /    \\");
        Console.WriteLine("|             /      \\");
        Console.WriteLine("|            /        \\");
        Console.WriteLine("|___________            ___________");
        Console.WriteLine("|*                                *");
        Console.WriteLine("|  *                            *");
        Console.WriteLine("|    *                        *");
        Console.WriteLine("|      *                    *");
        Console.WriteLine("|      /                   \\");
        Console.WriteLine("|     /           *         \\");
        Console.WriteLine("|    /         *     *       \\");
        Console.WriteLine("|   /       *          *      \\");
        Console.WriteLine("|  /     *                *    \\");
        Console.WriteLine("| /   *                     *   \\");
        Console.WriteLine("|/ *                           * \\");
    }

}