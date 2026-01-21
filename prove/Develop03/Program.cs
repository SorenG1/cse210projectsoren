using System;
using System.Formats.Asn1;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    
    {   
        string response = "yes";
        do
        {
       Random randomGenerator = new Random ();
       int number = randomGenerator.Next(0,101);

        int num_guess = -1;


        while (num_guess != number)
        
        {
        Console.WriteLine("Take a guess: ");
        num_guess = int.Parse(Console.ReadLine());

        
        if (num_guess == number)
        {
            Console.WriteLine ("You got it! ");
        }
        if (num_guess > number)
        {
            Console.WriteLine ("Try a little lower man...");
        }
        if (num_guess < number)

        {
            Console.WriteLine ("GO up!");
        }

        
        }
        Console.WriteLine("Do you want to play again? ");
        response = Console.ReadLine();

        }while (response == "yes");
    }
}