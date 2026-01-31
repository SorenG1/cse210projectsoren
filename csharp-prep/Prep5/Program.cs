using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        
        string userName = PromptUserName();
        int favNumber = FavoriteNumber();  

        int birthYear;
        PromptUserBirthYear(out birthYear);

        int squareNumber = SquaredNumber(favNumber);

        DisplayResult(userName, squareNumber, birthYear);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        return userName;
    }

    static int FavoriteNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.WriteLine("What is your birth year? ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquaredNumber(int favNumber)
    {
      int squareNumber = favNumber * favNumber;
      return squareNumber; 
    }

    static void DisplayResult(string userName, int squareNumber, int birthYear)
    {
        Console.WriteLine($"{userName}, your squared number is {squareNumber}");
        Console.WriteLine($"{userName}, this year you will turn {2026 - birthYear} years old. ");
    }
}