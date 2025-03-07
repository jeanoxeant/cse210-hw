using System;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write different numbers of your choice and type 0 when finished.");  
        string number;
        List<int> numbers = new List<int>();
        
        do
        {
            Console.Write("Type number:");
            number = Console.ReadLine();
            int usernumber = int.Parse(number);

            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
            //else
            //{
               // Console.WriteLine($"The number is {numbers.Count}.");
            //}

           // foreach (int num in numbers)
           // {
                //Console.WriteLine(num);
           // }

        }while (number != "0");

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maximum = numbers[0];

        foreach (int num in numbers)
        {
            if (num > maximum)
            {
                maximum = num;
            }
        }
        Console.WriteLine($"The largest number is: {maximum}");
    }
}