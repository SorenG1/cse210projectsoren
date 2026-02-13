using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start visualization activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;

                case "2":
                    new ReflectionActivity().Run();
                    break;

                case "3":
                    new ListingActivity().Run();
                    break;

                case "4":
                    new VisualizationActivity().Run();
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Please enter a valid option (1-5).");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    break;
            }

            if (running)
            {
                Console.WriteLine();
                Console.WriteLine("Press enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}