using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Make the Perfect Pancakes", "Cooking with Anna", 420);
        video1.AddComment(new Comment("Mike", "I made these this morning and they were great!"));
        video1.AddComment(new Comment("Sarah", "What brand of pan are you using?"));
        video1.AddComment(new Comment("Tom", "My kids loved them, thanks!"));
        videos.Add(video1);

        Video video2 = new Video("Top 5 Running Shoes of the Year", "Run Fast Reviews", 615);
        video2.AddComment(new Comment("Jessica", "I have the second pair and they are so comfortable."));
        video2.AddComment(new Comment("David", "You forgot to talk about the price."));
        video2.AddComment(new Comment("Emily", "Great review, very helpful."));
        video2.AddComment(new Comment("Chris", "Which one is best for long distance?"));
        videos.Add(video2);

        Video video3 = new Video("Learn C# in 10 Minutes", "Code Easy", 600);
        video3.AddComment(new Comment("Lucas", "This helped me a lot with my class."));
        video3.AddComment(new Comment("Rachel", "Can you make a video about lists?"));
        video3.AddComment(new Comment("John", "Very clear explanation."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}
