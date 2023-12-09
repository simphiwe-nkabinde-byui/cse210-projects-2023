class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine(_description);
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        _duration = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        ShowSpinner();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!!");
        ShowSpinner();
        Console.WriteLine($"\nYou have completeed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner();
    }
    public void ShowSpinner()
    {
        int interval = 100;
        string[] spinnerFrames = { "|", "/", "-", "\\" };

        for (int i = 0; i < 6; i++)
        {
            foreach (var frame in spinnerFrames)
            {
                Console.Write(frame);
                Thread.Sleep(interval);
                Console.Write("\b \b");
            }
        }

    }
    public void ShowCountDown(int totalSeconds)
    {
        for (int i = totalSeconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}