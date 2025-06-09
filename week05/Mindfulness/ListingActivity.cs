using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Welcome to the Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        List<string> results = GetListFromUser();
        _count = results.Count;
        Console.WriteLine($"\nYou listed {results.Count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");

    }

    public List<string> GetListFromUser()
    {
        List<string> items = new();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }
        return items;
    }




}