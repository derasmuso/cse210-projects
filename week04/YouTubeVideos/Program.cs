using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Why Darth Vader is the best villain", "StarWars Mania", 300);
        video1.AddComment(new Comment("Daniel", "I love Darth Vader!"));
        video1.AddComment(new Comment("Amy", "Star Wars is overrated."));
        video1.AddComment(new Comment("James", "What about Palpatine?"));
        video1.AddComment(new Comment("Charlie", "I really enjoyed your video!"));
        videos.Add(video1);

        Video video2 = new Video("Are cats or dogs better?", "Jeff", 150);
        video2.AddComment(new Comment("Rachel", "Cats are way better!"));
        video2.AddComment(new Comment("Ryan", "But dogs are mans best friend!"));
        video2.AddComment(new Comment("Caden", "You can actually play with dogs!"));
        video2.AddComment(new Comment("Carmen", "But cats are more cuddly"));
        videos.Add(video2);

        Video video3 = new Video("Why Mondays are actually the best day of the week", "MondayLover", 200);
        video3.AddComment(new Comment("Jim", "Are you crazy!"));
        video3.AddComment(new Comment("Richard", "What are you talking about?!"));
        video3.AddComment(new Comment("Joy", "I agree. I love Mondays!"));
        video3.AddComment(new Comment("Becky", "But what about Sundays? I love going to church!"));
        videos.Add(video3);



        foreach (var video in videos)
        {
            video.Display();
        }
    }
}