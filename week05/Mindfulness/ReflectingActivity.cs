using System;


public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {        
        "Think of a time when your ethics and morals of honesty were challenged.",
        "Think of a time when you had to sacrifice something important.",
        "Think of a time when you did not get a reward you believe you deserved.",
        "Think of a time when you had trouble with feelings of anger.",
        "Think of a time you were a leader of a class group that failed an assignment and how you managed the scenario.",
        "Think of a time you experienced low self-esteem and overcame these feelings.", 
        "Think of a time you experienced stress and managed the stress successfully.",
        "Think of a time you accomplished a goal and the decisions you made to help achieve the goal.",
        "Think of a time you had to choose a career or job, and how you made this decision. ",
        "Think of a time you were seeking counsel/support from another, and how you knew this was good counsel for you.",
    };
    private List<string> _questions = new List<string> {
        "What prompted you to make your final choice in this situation?",
        "What beliefs affected your decision, for example, personal, social norms, family, spiritual, and why?",
        "What would you do differently now, if anything?",
        "What life experiences have helped you in this scenario?",
        "What mentors have helped in shaping the choice made in this scenario?",
        "If granted one wish in this scenario, what would it be?",
        "If you could have seen the feature in this scenario, what would you have told yourself?",
        "If you could see the feature, would you make a different decision now?",
        "If you could be the HERO in this story, what character would you be?",
        "If you could choose any superpower in this scenario, what superpower would you have chosen?",
    };
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public string GenerateQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }
    public void PromptReflecting()
    {   
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            string question = GenerateQuestion();
            Console.Write(question + " ");
            GenerateSpinner(15);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
    //----------------------------------------------------//
    //public List<string> _prompts;
    //public List<string> _question;
    /*public void Run()
    {

    }
    public string GetRandomPrompt()
    {

    }
    public string GetRandomQuestion()
    {

    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {

    }*/
}