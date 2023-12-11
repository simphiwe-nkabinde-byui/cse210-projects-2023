class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public override void Run()
    {
        DisplayPrompt();
        GetListfromUser();
        Console.WriteLine($"You have listed {_count} items!");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNum = random.Next(0, _prompts.Count);
        return _prompts[randomNum];
    }
    public List<string> GetListfromUser()
    {
        List<string> userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string listItem = Console.ReadLine();
            userList.Add(listItem);
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
        _count = userList.Count();
        return userList;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.Write("\nYou may begin in: ");
        base.ShowCountDown(5);
        Console.WriteLine();
    }
}