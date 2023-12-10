class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>() {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void Run()
    {
        DisplayPrompt();
        DisplayQuestions();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNum = random.Next(0, _prompts.Count);
        return _prompts[randomNum];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomNum = random.Next(0, _prompts.Count);
        return _questions[randomNum];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);

        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            string randomQuestion = GetRandomQuestion();
            Console.Write($"\n> {randomQuestion} ");
            base.ShowSpinner(10);
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
    }
}