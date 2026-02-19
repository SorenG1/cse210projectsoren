using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Intro to C#", "Seron", 600);
        video1.AddComment(new Comment("Alice", "This was super clear, thanks!"));
        video1.AddComment(new Comment("Bob", "Helped me a lot with my homework."));
        video1.AddComment(new Comment("Charlie", "Can you make one about LINQ next?"));

        Video video2 = new Video("Space Facts", "AstroChannel", 420);
        video2.AddComment(new Comment("Diana", "I love space so much."));
        video2.AddComment(new Comment("Evan", "That black hole part was wild."));
        video2.AddComment(new Comment("Fiona", "Subbed for more content!"));

        Video video3 = new Video("Cooking Tortilla Española", "SpanishKitchen", 900);
        video3.AddComment(new Comment("Gabe", "This made me hungry."));
        video3.AddComment(new Comment("Hana", "Tried it and it turned out great."));
        video3.AddComment(new Comment("Ivan", "Reminds me of home."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}