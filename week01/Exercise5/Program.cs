using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        
        int number = PromptUserNumber();
        
        int square = SquareNumber(number);
        DisplayResult(name , square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        string userNumber = Console.ReadLine();
        int favoriteNumber = int.Parse(userNumber);
            
        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
            
        return squareNumber;
    }

    static void DisplayResult(string userName, int squareNumber)
    {    
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
}