using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("100 Campus Dr", "Rexburg", "ID", "USA");
        Address addr2 = new Address("200 Main St", "Boise", "ID", "USA");
        Address addr3 = new Address("Plaza Mayor 1", "Madrid", "Madrid", "Spain");

        Lecture lecture = new Lecture(
            "Intro to Astronomy",
            "A beginner-friendly overview of the night sky.",
            "10 Mar 2026",
            "7:00 PM",
            addr1,
            "Dr. Vega",
            120);

        Reception reception = new Reception(
            "Networking Night",
            "Meet local developers and share projects.",
            "15 Mar 2026",
            "6:30 PM",
            addr2,
            "rsvp@devmeetup.com");

        OutdoorGathering outdoor = new OutdoorGathering(
            "Stargazing in the Park",
            "Bring a blanket and enjoy the stars.",
            "20 Mar 2026",
            "9:00 PM",
            addr3,
            "Clear skies with cool temperatures");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("=== Standard Details ===");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("=== Full Details ===");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("=== Short Description ===");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine(new string('-', 40));
        }
    }
}