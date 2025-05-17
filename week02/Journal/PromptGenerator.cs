public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "How did I see the hand of the Lord in my life today?",
        "What can I be grateful for today?",
        "What's one thing I'm proud of accomplishing today?",
        "What is one thing I wish I could have done better?",
        "What have I learned today?",
        "What challenges did I face today?"

    };


    public string GetRandomPrompt()
    {
        Random prompt = new Random();
        var index = prompt.Next(_prompts.Count);
        return _prompts[index];
    }
}