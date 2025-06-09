public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Welcome to the Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")

    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        int cycle = _duration / 6;
        for (int i = 0; i < cycle; i++)
        {
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}