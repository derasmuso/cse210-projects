using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        var journal = new Journal();
        var promptGenerator = new PromptGenerator();
        bool programRunning = true;

        while (programRunning)
        {
            Console.WriteLine("Welcome to the journal program!");

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write("");
                string answer = Console.ReadLine();
                DateTime currentDate = DateTime.Now;
                string date = currentDate.ToShortDateString();
                var entry = new Entry
                {
                    _date = date,
                    _promptText = prompt,
                    _entryText = answer
                };
                journal.AddEntry(entry);
                Console.WriteLine();

            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("What is the file name? ");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
                Console.WriteLine();
            }

            else if (choice == "4")
            {
                Console.Write("What is the file name? ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
                Console.WriteLine();
            }

            else if (choice == "5")
            {
                programRunning = false;
            }

            else
            {
                Console.WriteLine("That is not a valid option. Please try again.\n");
            }

        }






    }
}