using System;


public class ListingActivity : Activity
{
     private List<string> _prompts = new List<string> {
        "What goals this week helped you feel accomplished?",
        "Who has been a positive influence to help you accomplish your goals?",
        "What are some personal strengths you would like to work on?",
        "What activities would bring you joy this week?",
        "What are some habits you would like to change?",
        "What are you grateful for this week?",
        "How can you show your love to others?",
        "Where do you see yourself in 2 weeks?",
        "What music brings you peace?",
        "What have you used this week to track your progress toward goals?",
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public void PromptListing()
    {   
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        GenerateCountdownTimer(5);
        Console.WriteLine();
                
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }
    /*
    public int _count;
    public List<string> _prompts;
    public void Run()
    {

    }

    public string GetRandomPrompt()
    {

    }

    public List<string> GetListFromUser()
    {

    }*/
}