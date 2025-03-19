using System;


public class PromptGenerator
{
    //public List<string> _prompts = new List<string>();

    static string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}