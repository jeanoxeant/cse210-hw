using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number");
        //string magicNumber = Console.ReadLine();
        //int number = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        string magicNumber = number.ToString();

        string guessNumber;


        do
        {
            Console.WriteLine("What is the guess number");
            guessNumber = Console.ReadLine();
            int guess = int.Parse(guessNumber);
            
            
            if (guess < number)
            {
                Console.WriteLine("Please choose a Higher number.");   
            }
            else if (guess > number)
            {
                Console.WriteLine("Please choose a Lower number."); 
            }
            else 
            {
                Console.WriteLine("Congratulations!!! You guessed the magic number.");
            }
        }while (guessNumber != magicNumber);

        





        



    }
}