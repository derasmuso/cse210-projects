public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string desciption)
    {
        _name = name;
        _description = desciption;

    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int spinnerIndex = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(500);
            Console.Write("\b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
        Console.Write(" ");
        Console.Write("\b");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string output = i.ToString();
            Console.Write(output);
            Thread.Sleep(1000);
            Console.Write(new string('\b', output.Length));
        }
        Console.Write(" ");
        Console.Write("\b");
    }


}