using System;
using System.Collections.Generic;

// Exceeding requirements:
// 1. The program has a small library of scriptures and picks one at random
//    every time it starts.
// 2. When hiding words, the program only picks words that are not hidden yet,
//    so every time you press enter you see new words disappear.

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>();

        library.Add(new Scripture(new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));

        library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));

        library.Add(new Scripture(new Reference("1 Nephi", 3, 7),
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));

        library.Add(new Scripture(new Reference("Moroni", 10, 4, 5),
            "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."));

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        string input = "";

        while (input != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}
