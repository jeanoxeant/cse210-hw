using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Student student = new Student();
        string name = student.GetName();
        Console.WriteLine(name);
    }
}