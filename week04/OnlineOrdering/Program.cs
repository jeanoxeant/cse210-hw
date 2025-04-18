using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address = new Address ();
        address.GetAdressInfo("Respaldo 10", "Villa Mella", "Santo Domingo", "Dominican Republic");
    }
}