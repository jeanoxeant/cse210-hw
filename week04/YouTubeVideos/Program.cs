using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video("Playing golf", "Shannon", 22);
        Video video2 = new Video("Drawing Tutorial", "Natacha", 30);
        Video video3 = new Video("Teaching", "John", 140);
        
        video1.AddComment(new Comment("@Jeff", "not like it!"));
        video1.AddComment(new Comment("@Wilnix", "Like it!"));

        video2.AddComment(new Comment("@David", "That's my passion!"));
        video2.AddComment(new Comment("@Joshua", "How can I be an expert in drawing?"));

        video3.AddComment(new Comment("@Jonas", "Love teaching too!"));
        video3.AddComment(new Comment("@Roberto", "Teaching English is not that simple!"));

        List<Video> videos = new List<Video> {video1, video2, video3};
        foreach(var video in videos)
        {
            video.DisplayInformation();
        }

    }
}