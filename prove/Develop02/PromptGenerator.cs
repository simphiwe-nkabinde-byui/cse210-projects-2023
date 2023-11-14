public class PromptGenerator
{
    public string[] _prompts = new string[] {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I most proud of today?",
        "What are you are most grateful for today?",
        "How did you stay true to yourself today?"
    };


    public string getRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(1, _prompts.Length)];
    }
}