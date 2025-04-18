using System;


public class Address
{
    private string StreetAdress {get; set;} 
    private string City{get; set;} 
    private string Province{get; set;} 
    private string Country{get; set;} 

    public string GetAdressInfo( string streetAdress, string city, string province, string country)
    {
        StreetAdress = streetAdress;
        City = city;
        Province = province;
        Country = country;
        Console.WriteLine($"{streetAdress}, {city}, {province}, {country}.");

        if (country == "USA")
        {
            return "customer is living inside of USA.";
        }
        
        else
        {
            return "customer is living outside of USA.";
        }

        
    }

    /*
    public string GetAdress()
    {
        return $"{_streetAdress}, {_city}, {_province}, {_country}."
    }*/
}