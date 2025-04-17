using System;


public class Address
{
    private string _streetAdress;
    private string _city;
    private string _province;
    private string _country;

    public string GetInfo()
    {
        if (_country == USA)
        {
            return "customer is living inside of USA."
        }
        
        else
        {
            return "customer is living outside of USA."
        }
    }

    public string GetAdress()
    {
        return $"{_streetAdress}, {_city}, {_province}, {_country}."
    }
}