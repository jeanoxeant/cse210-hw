using System;


class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? ",
            "How has reading the scriptures today helped me seek the Kingdom of God?" ,
            "How has the scripture study today helped me in planning spiritual family/personal/ professional goals? ",
            "What is my plan to experience some form of spiritual nourishment today? ",
            "What is my plan to experience some form of physical nourishment today? ",
            "What is my priority goal for the Day, Week, Month, Year? What steps do I take? ",
            "Is there a need I have today that I do not know how to nourish? ",
            "What brings me spiritual, physical, and mental moments of joy and/or peace? ",
            "What challenges/trials feel overwhelming, is there support I can go to such as; prayer, meditation, church, school, or family? ",
            "Who are the people in my life today I look to as an example of strength, love, support, or unconditional acceptance? ",
            "What is at least one part of my self I honor and am thankful to my higher power/ Heavenly Father for blessing me with this gift/talent? ",
        };

        string selectMenu = "0";
        while (selectMenu != "5")
        {
            Console.WriteLine("\nWelcome to my Journal! ");
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.WriteLine("\nWhat would you like to do? ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                string prompt = GetRandomPrompt(prompts);
                journal.AddEntry(prompt);
            }

            else if (option == "2")
            {
                journal.DisplayEntries();
            }

            else if (option == "3")
            {
                journal.SaveToFile();
            }

            else if (option == "4")
            {
                journal.LoadFromFile();
            }

            else if (option == "5")
            {
                break;
            }

            else 
            {
                Console.WriteLine("Invalid choice. ");
            }
        }
        Console.WriteLine("Thank you for using my journal! Hope to see you soon!"); // Say good bye to the user.
    }

    static string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
       

}