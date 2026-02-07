using System;
using System.Runtime.CompilerServices;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    // Constructor
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
    // Displays the information in a reabadle format.
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");

    }

    public string ToFileString()
    {  
        return $"{_date}, {_prompt}, {_response}";
    }
}