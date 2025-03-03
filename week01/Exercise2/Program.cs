using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade?");

        string userGrade = Console.ReadLine();
        float grade = int.Parse(userGrade);
        string letter;
        string sign;

        //Section for sign.

        if (grade % 10 < 3)
        {
            sign = "-";
        }
        else if (grade % 10 < 3 || grade < 60 || grade >= 93)
        {
            sign = " ";
        }
        else if (grade % 10 >=7)
        {
            sign = "+";
        }
        else
        {
            sign = " ";
        }

        //Section just for the Letter.

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade <= 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade <= 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade <= 70)
        {
            letter = "D";
            
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have a {letter}{sign}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!!! You have passed the class.");
        }
        else
        {
            Console.WriteLine("You have failed the class, but you can do it better next time if you study more.");
        }


    }
}