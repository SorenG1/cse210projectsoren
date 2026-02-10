using System;
using System.Formats.Asn1;
using System.Net;
using System.Security.Cryptography.X509Certificates;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ---------------------------------------------------------
        // EXTRA CREDIT (100%): 
        // I added a scripture library so the program chooses a 
        // random scripture each time it runs.
        // ---------------------------------------------------------

        List<Scripture> library = new List<Scripture>()
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son " +
                "that whosoever believeth in him should not perish but have everlasting life."
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding " +
                "in all thy ways acknowledge him and he shall direct thy paths."
            ),

            new Scripture(
                new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be and men are that they might have joy."
            )
        };

        Random rand = new Random();
        Scripture scripture = library[rand.Next(library.Count)];

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (true)
        {
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }
        }
    }
}