using System;

// Exceeding requirements:
// 1. In the Reflecting and Listing activities, a question or prompt is not
//    repeated until all of them have been used at least once in the session.
// 2. The program keeps a log of how many times each activity was done in the
//    session and shows it when the user quits.

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                breathing.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                reflecting.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                listing.Run();
                listingCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Activities done in this session:");
        Console.WriteLine($"  Breathing: {breathingCount}");
        Console.WriteLine($"  Reflecting: {reflectingCount}");
        Console.WriteLine($"  Listing: {listingCount}");
        Console.WriteLine("Goodbye!");
    }
}
