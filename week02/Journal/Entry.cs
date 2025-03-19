using System;


public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    //public void Display()
    //{
        //Console.WriteLine($"{_entryText} {_promptText} {_date}");
    //}

    //public string _prompt;
    //public string _response;
    //public string _date;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        
    }

    public string GetDate()
    {
        return _date;
    }
    public string GetPrompt()
    {
        return _promptText;
    }

    public string GetResponse()
    {
        return _entryText;
    }

    /*public string GetDate()
    {
        return _date;
    }
    */
    public override string ToString()
    {
        return $"Date: {_date} - Prompt: {_promptText} \n{_entryText}\n";
    }
}