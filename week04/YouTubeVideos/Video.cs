using System;
using System.Collections.Generic;

public class Video
{
    private string Title{get; set;}
    private string Author{get; set;}
    public double Length;
    public List<Comment> comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments}");
        //int count = 1;
        foreach (var comment in comments) 
        {
            Console.Write($"-- {comment.ToString()}. ");
            //comment.DisplayComment();
        }

        Console.WriteLine(" ");

    }

    

    //DisplayVideoSummary();


}