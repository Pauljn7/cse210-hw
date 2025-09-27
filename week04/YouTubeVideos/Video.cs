using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Intro to C#", "Alice", 600);
        video1.AddComment(new Comment("John", "Nice video!"));
        video1.AddComment(new Comment("Mary", "Very helpful."));
        video1.AddComment(new Comment("Sam", "Can you explain classes more?"));
        videos.Add(video1);

        Video video2 = new Video("Object Oriented Programming", "Bob", 720);
        video2.AddComment(new Comment("Lucy", "Good job explaining."));
        video2.AddComment(new Comment("Tom", "Thanks, this helped."));
        video2.AddComment(new Comment("Anna", "Inheritance is clear now."));
        videos.Add(video2);

        Video video3 = new Video("Abstraction Basics", "Charlie", 540);
        video3.AddComment(new Comment("Dave", "This was useful."));
        video3.AddComment(new Comment("Eve", "I liked the examples."));
        video3.AddComment(new Comment("Paul", "Looking forward to the next one!"));
        videos.Add(video3);

        foreach (Video v in videos)
        {
            v.DisplayInfo();
        }
    }
}

