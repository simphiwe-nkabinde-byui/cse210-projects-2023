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
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completeed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }
    public void ShowSpinner(int durationInSeconds)
    {
        string[] spinnerFrames = { "|", "/", "-", "\\", };
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(durationInSeconds);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            foreach (var frame in spinnerFrames)
            {
                Console.Write(frame);
                Thread.Sleep(200);
                Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
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