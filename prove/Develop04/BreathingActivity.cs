class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public override void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("\n\nBreathe in...");
            base.ShowCountDown(4);

            Console.Write("\nNow breathe out...");
            base.ShowCountDown(6);
            currentTime = DateTime.Now;
        }
    }
}